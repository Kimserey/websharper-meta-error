(function()
{
 var Global=this,Runtime=this.IntelliFactory.Runtime,UI,Next,Doc;
 Runtime.Define(Global,{
  MetaCrash:{
   Client:{
    page:function()
    {
     return Doc.TextNode("Hello world");
    }
   }
  }
 });
 Runtime.OnInit(function()
 {
  UI=Runtime.Safe(Global.WebSharper.UI);
  Next=Runtime.Safe(UI.Next);
  return Doc=Runtime.Safe(Next.Doc);
 });
 Runtime.OnLoad(function()
 {
  return;
 });
}());
