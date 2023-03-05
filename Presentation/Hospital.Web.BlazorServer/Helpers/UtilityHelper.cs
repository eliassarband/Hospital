using MudBlazor;
using Stimulsoft.Blockly.Model;
using Stimulsoft.Data.Expressions.NCalc.Domain;
using System.Data;

namespace Hospital.Web.BlazorServer.Helpers
{
    public static class UtilityHelper
    {
        public static string GenerateIdentifier(string Prefix,int Id)
        {
            string identifier = "";
            if (!String.IsNullOrEmpty(Prefix))
            {
                

                if (Id < 100000)
                {
                    identifier = "00000" + Id.ToString();
                    identifier = identifier.Substring(identifier.Length - 5, 5);
                }
                else
                {
                    identifier = Id.ToString();
                }

                identifier = Prefix + identifier;

                                
            }
            else
            {
                identifier = Id.ToString();
            }

            return identifier;
        }
    }
}
