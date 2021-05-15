using System.Collections.Generic;

namespace AnaliseFinanceira
{
    public static class AtribuirCategoria
    {
        public static string Compras(string cFOP)
        {
            Dictionary<string, string> cat = new Dictionary<string, string>()
            {
                {"5101","Compras"},
                {"6101","Compras"},
                {"5102","Compras"},
                {"6102","Compras"},
                {"5104","Compras"},
                {"5105","Compras"},
                {"5106","Compras"},
                {"5401","Compras"},
                {"5403","Compras"},
                {"5405","Compras"},
                {"5151","Filiais"},
                {"5152","Filiais"},
                {"5202","Devolução"},
                {"5411","Bonificação"},
                {"5910","Bonificação"},
                {"5911","Bonificação"},
                {"5915","Remessas"},
                {"5949","Remessas"},
                {"5929","Cupom"},
            };
            string result;
            cat.TryGetValue(cFOP, out result);
            if (result == null) return "Não-Classificado";
            return result;
        }

        public static string Vendas(string cFOP)
        {
            Dictionary<string, string> cat = new Dictionary<string, string>()
            {
                {"5102","Produtos"},
                {"5405","Produtos"},
                {"5151","Filiais"},
                {"5152","Filiais"},
                {"5202","Devolução"},
                {"5411","Bonificação"},
                {"5910","Bonificação"},
                {"5911","Bonificação"},
                {"5915","Remessas"},
                {"5949","Remessas"},
                {"5929","Cupom"},
                {"6929","Cupom"},
                {"6102","Produtos"},
                {"5933", "Serviços"},
                {"6933", "Serviços"}
            };
            string result;
            cat.TryGetValue(cFOP, out result);
            if (result == null) return "Não-Classificado";
            return result;
        }
    }
}
