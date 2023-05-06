using Hospital.Application.Queries;
using Hospital.Web.BlazorServer.Models;
using Hospital.Web.BlazorServer.Models.Auth;
using MediatR;
using MudBlazor;
using System.Data;

namespace Hospital.Web.BlazorServer.Helpers
{
    public class SettingHelper
    {
        private readonly IMediator _mediator;

        public SettingHelper(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<CurrencySetting> GetCurrencySetting()
        {
            CurrencySetting currencySetting = new CurrencySetting()
            {
                CurrencySymbol = "$",
                CurrencyTextBoxFormat = "#,##0 $",
                CurrencyGridCellFormat = "{0:#,##0 $}"
            };

            var hospitalInformation = await _mediator.Send(new GetHospitalInformationByIdQuery(1));

            if (hospitalInformation != null)
            {
                if (String.IsNullOrEmpty(hospitalInformation.CurrencySymbol))
                {
                    currencySetting.CurrencySymbol = "$";
                    currencySetting.CurrencyTextBoxFormat = "#,##0 $";
                    currencySetting.CurrencyGridCellFormat = "{0:#,##0 $}";
                }
                else
                {
                    currencySetting.CurrencySymbol = hospitalInformation.CurrencySymbol;
                    currencySetting.CurrencyTextBoxFormat = "#,##0 " + hospitalInformation.CurrencySymbol;
                    currencySetting.CurrencyGridCellFormat = "{0:#,##0 " + hospitalInformation.CurrencySymbol + "}";
                }
            }

            return currencySetting;
        }
    }
}
