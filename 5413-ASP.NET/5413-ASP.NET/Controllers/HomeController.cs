using System.Diagnostics;
using System.Runtime.Serialization;
using _5413_ASP.NET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

namespace _5413_ASP.NET.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        [Route("")]
        [Route("/")]
        [Route("[action]")]
        public IActionResult Index(int id)
        {
            

            ValenciasData valenciasData = new ValenciasData(); // onde fica as tabelas criadas

            return View(valenciasData.Valencias);
            
        }



        [Route("[action]")]
        public IActionResult Privacy(int id)
        {
            ViewBag.id = id;
            RubricasDatacs rubricasDatacs = new RubricasDatacs(); // onde fica as tabelas criadas
            //query de procura de uma rubrica pelo id
            Rubrica rubrica = rubricasDatacs.Rubricas.FindAll(r => r.IdRubrica == id).First() as Rubrica;
            
            return View(rubrica);
        }
        
        public IActionResult Details()
        {
            

            return View();
        }
        /// <summary>
        /// criado a funcao para mostrar as valências onde tem o nome da views criada
        /// </summary>
        /// <returns></returns>
        [Route("[action]")]
        public IActionResult Detalhes_Valencias()//lembra de colocar a views criada para as valências
        {
            ValenciasData valenciasData = new ValenciasData(); // onde fica as tabelas criadas
            
            return View(valenciasData.Valencias);
        }



       // public IActionResult Detalhes_Rubricas()//lembra de colocar a views 
        //{
          //  RubricasDatacs rubricasDatacs = new RubricasDatacs();// onde fica as tabelas criadas

            //return View(rubricasDatacs);
       // }

        public IActionResult Detalhes_MapaFina()//lembra de colocar a views 
        {
            MapaFinanceiro mapafinaceiro = new MapaFinanceiro();// onde fica as tabelas criadas

            return View(mapafinaceiro);
        }




        [Route("[action]")]
        public IActionResult Formulario()
        {
             

            return View();
        }

        [Route("[action]")]
        public IActionResult FormBinding()
        {


            return View();
        }


        /// <summary>
        /// Para inserir uma nova valência através de um formulário
        /// utilido o IFormCollection para receber os dados do formulário
        /// httpPost para receber os dados do formulário
        /// e sua rota é [action] que é o nome da ação
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        /// 


        [HttpPost]
        [Route("[action]")]
        public IActionResult Valencia_Form(IFormCollection form) // lembra de colocar a views criada para as valências
        {
            var keys = form.Keys;

            if (form.ContainsKey("NomeValencia") && form.ContainsKey("Abreviatura"))
            {
                if (form.TryGetValue("NomeValencia", out StringValues NomeValencia) &&
                    form.TryGetValue("Abreviatura", out StringValues Abreviatura) &&
                    !string.IsNullOrEmpty(NomeValencia) &&
                    !string.IsNullOrEmpty(Abreviatura))
                {

                    ViewBag.Message = $"Valência adicionada com sucesso | Nome:{NomeValencia} | Abrev: {Abreviatura}";


                }
                else
                {
                    ViewBag.Message = "Erro: O formulario nãocontem Informações!";
                }
            }

            return View("Formulario");
        }



        [HttpPost]
        [Route("[action]")]
        public IActionResult ValenciaBinding_Form(ValenciaForm vale) // lembra de colocar a views criada para as valências
        {
            if(vale != null)
            {
                if(ModelState.IsValid)
                {
                    // Aqui você pode adicionar a lógica para salvar a valência no banco de dados ou em uma lista
                    ViewBag.Message = $"Valência adicionada com sucesso | Nome: {vale.DescValencia} | Abrev: {vale.AbvValencia}";
                    //ModelState.Clear(); // Limpa o estado do modelo após a validação bem-sucedida
                    return View("FormBinding");
                }
               
            }

            return View("FormBinding", vale);
        }








        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
