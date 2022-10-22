using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialSection.Model;
using RestSharp;

namespace FinancialSection.Presenter
{
    internal class DataHandler
    {
        // Использовать не заранее подготовленную модельку данных, а сам класс, в котором реализована логика, - как модель данных
        public readonly string _exam;
        public void Handler()
        {
            //json:
            //Content - само значение json-файла (null, если пустой вариант)
            //ErrorException (System.Exception) - null в удачном исходе событий и в пустой форме
            //StatusCode (System.Net.HttpStatusCode) - OK в удачном исходе событий, 0 в пустой форме
            //ResponseStatus (RestSharp.ResponseStatus) - Completed в удачном исходе событий, None в пустой форме 
            //IsSuccessful (bool) - true в удачном исходе событий, false в пустой форме (может и еще в случае ошибки)
            //IsSuccessStatusCode (bool) - true в удачном исходе событий, false в пустой форме (может и еще в случае ошибки)


            // 1) Логика для обработки каждого контроллера АПИ
            // 2) Парсинг полученных элементов



            APIController controller = new APIController();
            var L = controller.CurrencyLayer(ActionsAPI.PRECIOUS_METALS);
        }

        //private RestResponse GetData()
        //{

        //}
    }
}
