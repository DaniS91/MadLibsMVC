using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() { return View(); }
  
    [Route("/result")]
    public ActionResult Result(string expression, string noun1, string noun2, string sound1, string sound2, string verb1, string verb2, string month, string beverage, string adjective1, string adjective2, string color1, string color2, string pluralnoun1, string pluralnoun2, string number1, string number2)
    // the name of the parameters must match the value of the name attribute on the form inputs
    {
      FormVariable myFormVariable = new FormVariable();
      myFormVariable.Expression = expression;
      myFormVariable.Noun1 = noun1;
      myFormVariable.Noun2 = noun2;
      myFormVariable.Color1 = color1;
      myFormVariable.Color2 = color2;
      myFormVariable.Sound1 = sound1;
      myFormVariable.Sound2 = sound2;
      myFormVariable.Verb1 = verb1;
      myFormVariable.Verb2 = verb2;
      myFormVariable.Adjective1 = adjective1;
      myFormVariable.Adjective2 = adjective2;
      myFormVariable.PluralNoun1 = pluralnoun1;
      myFormVariable.PluralNoun2 = pluralnoun2;
      myFormVariable.Beverage = beverage;
      myFormVariable.Month = month;
      myFormVariable.Number1 = number1;
      myFormVariable.Number2 = number2;
      return View(myFormVariable);
    }
  }  
}