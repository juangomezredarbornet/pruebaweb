
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AplicacionWebPrueba.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public double Numero1 { get; set; }

        [BindProperty]
        public double Numero2 { get; set; }

        public double? Resultado { get; set; }

        public void OnGet()
        {
        }

        // Método para el envío tradicional del formulario
        public void OnPostSumar()
        {
            Resultado = Numero1 + Numero2;
        }

        // Método utilizado por JavaScript fetch()
        public JsonResult OnPostSumarAjax()
        {
            double resultado = Numero1 + Numero2;

            return new JsonResult(new
            {
                resultado = resultado
            });
        }
    }
}
