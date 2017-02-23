(function()
{
 var Global=this,Runtime=this.IntelliFactory.Runtime;
 Runtime.Define(Global,{
  Library1:{
   FieldType:Runtime.Class({
    Test:function()
    {
     return true;
    }
   })
  }
 });
 Runtime.OnLoad(function()
 {
  return;
 });
}());
