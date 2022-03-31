/**@preserve  GeneXus C# 10_3_15-115824 on 3/31/2022 0:18:56.87
*/
gx.evt.autoSkip = false;
gx.define('alerts', true, function (CmpContext) {
   this.ServerClass =  "alerts" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.setCmpContext(CmpContext);
   this.ReadonlyForm = true;
   this.hasEnterEvent = false;
   this.skipOnEnter = false;
   this.autoRefresh = true;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
   };
   this.e12322_client=function()
   {
      this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e13322_client=function()
   {
      this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXLastCtrlId =0;
   this.ALERTIFY1Container = gx.uc.getNew(this, 2, 0, "", this.CmpContext + "ALERTIFY1Container", "this");
   var ALERTIFY1Container = this.ALERTIFY1Container;
   ALERTIFY1Container.setC2ShowFunction(function(UC) { UC.(); });
   this.setUserControl(ALERTIFY1Container);
   this.Events = {"e12322_client": ["ENTER", true] ,"e13322_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[],[]];
   this.InitStandaloneVars( );
});
