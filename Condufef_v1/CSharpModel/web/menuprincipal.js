/**@preserve  GeneXus C# 10_3_15-115824 on 12/30/2021 22:9:13.61
*/
gx.evt.autoSkip=!1;gx.define("menuprincipal",!1,function(){var t,n;this.ServerClass="menuprincipal";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.e130t1_client=function(){this.clearMessages();this.addMessage(this.GPXMENU1Container.Code);this.refreshOutputs([])};this.e140t2_client=function(){this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e150t2_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];t=this.GXValidFnc;this.GXCtrlIds=[3];this.GXLastCtrlId=3;this.GPXMENU1Container=gx.uc.getNew(this,6,0,"gpxMenu","GPXMENU1Container","Gpxmenu1");n=this.GPXMENU1Container;n.addV2CFunction("AV5gpxMenuItems","vGPXMENUITEMS","SetMenu");n.addC2VFunction(function(n){n.ParentObject.AV5gpxMenuItems=n.GetMenu();gx.fn.setControlValue("vGPXMENUITEMS",n.ParentObject.AV5gpxMenuItems)});n.setProp("CollapsedTitle","Collapsedtitle","Main Menu","str");n.setProp("ResizeWidth","Resizewidth","800","str");n.setProp("Code","Code","","str");n.setProp("CollapsedBackColor","Collapsedbackcolor","#999","str");n.setProp("MainBackColor","Mainbackcolor","#aaa","str");n.setProp("SecondaryBackColor","Secondarybackcolor","#bbb","str");n.setProp("FontColor","Fontcolor","black","str");n.setProp("Visible","Visible",!0,"bool");n.setProp("Enabled","Enabled",!0,"boolean");n.setProp("Class","Class","","char");n.setC2ShowFunction(function(n){n.show()});n.addEventHandler("ItemClick",this.e130t1_client);this.setUserControl(n);t[3]={fld:"TABLE1",grid:0};this.AV5gpxMenuItems=[];this.Events={e140t2_client:["ENTER",!0],e150t2_client:["CANCEL",!0],e130t1_client:["GPXMENU1.ITEMCLICK",!1]};this.EvtParms.REFRESH=[[],[]];this.EvtParms["GPXMENU1.ITEMCLICK"]=[[{av:"this.GPXMENU1Container.Code",ctrl:"GPXMENU1",prop:"Code"}],[]];this.InitStandaloneVars()});gx.createParentObj(menuprincipal)