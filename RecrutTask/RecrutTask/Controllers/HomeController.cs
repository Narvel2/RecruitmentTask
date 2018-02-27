using RecrutTask.Models;
using RecrutTask.Services;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace RecrutTask.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Declare a connection with EF
        /// </summary>
    

        DalContext db = new DalContext();
        
        /// <summary>
        /// My Default Action defined in RouteConfig, returne a View "GetInput"
        /// </summary>
        /// <returns></returns>

        public ActionResult GetInput()
        {
            return View("GetInput");
        }
        

        /// <summary>
        /// My Post method if InputString is filled correct open connection with api and add to database InputString and TranslatedString and return
        /// New View "TranslatedString" and model "dataModelEntity"
        /// </summary>
        /// <param name="dataModelEntity"></param>
        /// <returns></returns>

    
        [HttpPost]
        public async Task<ActionResult> GetInput(DataModelEntity dataModelEntity)
        { 
            if (ModelState.IsValid)
            {
                var caller = new ApiCaller();
                var cos = await caller.CallToApi(dataModelEntity.InputString);
                dataModelEntity.TranslatedString = cos.ToString();
                db.dataModelEntities.Add(dataModelEntity);
                db.SaveChanges();

                return View("TranslatedString",dataModelEntity);
            }

            return Content("You must write a text first");
        }
    }
}