/**@preserve  GeneXus C# 10_3_15-115824 on 1/26/2022 20:7:12.10
*/
gx.evt.autoSkip=!1;gx.define("sidebar",!0,function(n){var i,t;this.ServerClass="sidebar";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.e132d1_client=function(){this.clearMessages();this.addMessage(this.GPXMENU1Container.Code);this.refreshOutputs([])};this.e142d2_client=function(){this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e152d2_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];i=this.GXValidFnc;this.GXLastCtrlId=0;this.GPXMENU1Container=gx.uc.getNew(this,2,0,"gpxMenu",this.CmpContext+"GPXMENU1Container","Gpxmenu1");t=this.GPXMENU1Container;t.addV2CFunction("AV5gpxMenuItems","vGPXMENUITEMS","SetMenu");t.addC2VFunction(function(n){n.ParentObject.AV5gpxMenuItems=n.GetMenu();gx.fn.setControlValue("vGPXMENUITEMS",n.ParentObject.AV5gpxMenuItems)});t.setProp("CollapsedTitle","Collapsedtitle","","str");t.setProp("ResizeWidth","Resizewidth","10000","str");t.setProp("Code","Code","","str");t.setProp("CollapsedBackColor","Collapsedbackcolor","#999","str");t.setProp("MainBackColor","Mainbackcolor","#aaa","str");t.setProp("SecondaryBackColor","Secondarybackcolor","#bbb","str");t.setProp("FontColor","Fontcolor","black","str");t.setProp("Visible","Visible",!0,"bool");t.setProp("Enabled","Enabled",!0,"boolean");t.setProp("Class","Class","","char");t.setC2ShowFunction(function(n){n.show()});t.addEventHandler("ItemClick",this.e132d1_client);this.setUserControl(t);this.AV5gpxMenuItems=[];this.Events={e142d2_client:["ENTER",!0],e152d2_client:["CANCEL",!0],e132d1_client:["GPXMENU1.ITEMCLICK",!1]};this.EvtParms.REFRESH=[[],[]];this.EvtParms["GPXMENU1.ITEMCLICK"]=[[{av:"this.GPXMENU1Container.Code",ctrl:"GPXMENU1",prop:"Code"}],[]];this.InitStandaloneVars()})