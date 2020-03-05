using CaLOLateAPI.Models;
using Newtonsoft.Json;
using System;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CaLOLateAPI.Controllers
{
    [RoutePrefix("champ")]
    [EnableCors("*", "*", "*")]
    public class ChampionController : ApiController
    {
    }
}
