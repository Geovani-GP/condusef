/**@preserve  GeneXus C# 10_3_15-115824 on 1/23/2022 2:12:29.25
*/
gx.evt.autoSkip=!1;gx.define("catalog_de_categoria",!1,function(){this.ServerClass="catalog_de_categoria";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.A40000GXC1=gx.fn.getIntegerValue("GXC1",".");this.AV6NextValue=gx.fn.getIntegerValue("vNEXTVALUE",".");this.AV8cambs=gx.fn.getControlValue("vCAMBS");this.AV7cambsdsc=gx.fn.getControlValue("vCAMBSDSC")};this.e120x2_client=function(){this.executeServerEvent("'GUARDAR '",!1,null,!1,!1)};this.e140x2_client=function(){this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e150x2_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[3,8,15];this.GXLastCtrlId=15;n[3]={fld:"TABLE1",grid:0};n[8]={fld:"TABLE2",grid:0};n[15]={fld:"TABLE3",grid:0};this.AV6NextValue=0;this.AV8cambs={};this.AV7cambsdsc="";this.Events={e120x2_client:["'GUARDAR '",!0],e140x2_client:["ENTER",!0],e150x2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[],[]];this.EvtParms["'GUARDAR '"]=[[{av:"AV6NextValue",fld:"vNEXTVALUE",pic:"ZZZ9",nv:0},{av:"AV8cambs",fld:"vCAMBS",pic:"",nv:null},{av:"AV7cambsdsc",fld:"vCAMBSDSC",pic:"",nv:""}],[{av:"AV8cambs",fld:"vCAMBS",pic:"",nv:null}]];this.setVCMap("A40000GXC1","GXC1",0,"int");this.setVCMap("AV6NextValue","vNEXTVALUE",0,"int");this.setVCMap("AV8cambs","vCAMBS",0,"cambs");this.setVCMap("AV7cambsdsc","vCAMBSDSC",0,"svchar");this.InitStandaloneVars()});gx.createParentObj(catalog_de_categoria)