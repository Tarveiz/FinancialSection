using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialSection.Model;
using RestSharp;
using System.Text.Json;
using System.Timers;
using System.Threading;

namespace FinancialSection.Presenter
{
    internal class DataHandler
    {
        // Использовать не заранее подготовленную модельку данных, а сам класс, в котором реализована логика, - как модель данных
        private string _str { get; set; }
        public List<string> CurrencyResult { get; set; } = new List<string>();


        APIController controller = new APIController();

        //Конструктор должен принимать параметр - настройки пользователя (валюты, драг металлы или еще чего)
        public DataHandler()
        {
            //настройки с формы!!!

            

            CurrencyResult.Add("str");
            //json:
            //Content - само значение json-файла (null, если пустой вариант)
            //ErrorException (System.Exception) - null в удачном исходе событий и в пустой форме
            //StatusCode (System.Net.HttpStatusCode) - OK в удачном исходе событий, 0 в пустой форме
            //ResponseStatus (RestSharp.ResponseStatus) - Completed в удачном исходе событий, None в пустой форме 
            //IsSuccessful (bool) - true в удачном исходе событий, false в пустой форме (может и еще в случае ошибки)
            //IsSuccessStatusCode (bool) - true в удачном исходе событий, false в пустой форме (может и еще в случае ошибки)


            //В этом классе будет куча полей, к которым будут привязывать результаты распаршенных данных
            //от АПИ-х. Вьюха будет привязывать эти поля к своим свойствам и отображать. Также важно использовать
            //интерфейс для динамического изменения в привязке данных. Есть тема с обновлением информации:
            //либо обновляем каждые условно 5 минут работы программы, но тогда лимит на клиентские запросы
            //довольно быстро исчерпается, либо использовать кнопку обновить на форме с действий пользователя, либо
            //еще какие варианты

            // 1) Логика для обработки каждого контроллера АПИ
            // 2) Парсинг полученных элементов с учетом настроек пользователя


            //var readTask = request.ResponseWriter == null ? ReadResponse() : ReadAndConvertResponse();


            //if(json){парсинг json} else {парсинг xml}






            var responseTest = controller.RussiaBank(ActionsAPI.CURRENCY_VALUE);



            //var response = GetData();
        }
        private RestResponse GetData()
        {
            var response = controller.CurrencyLayer(ActionsAPI.PRECIOUS_METALS); //json
            
            if (response.ErrorException != null && (response.StatusCode != 0 && response.StatusCode != System.Net.HttpStatusCode.OK))
            {
                response = controller.FixerIO(ActionsAPI.PRECIOUS_METALS); //json
                if (response.ErrorException != null && (response.StatusCode != 0 && response.StatusCode != System.Net.HttpStatusCode.OK))
                {
                    response = controller.RussiaBank(ActionsAPI.PRECIOUS_METALS); //xml
                    if (response.ErrorException != null && (response.StatusCode != 0 && response.StatusCode != System.Net.HttpStatusCode.OK))
                    {
                        return response; //Подумать над выводом
                    }
                }
            }
            return response;
        }
    }
}
