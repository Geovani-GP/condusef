/**@preserve  GeneXus C# 10_3_15-115824 on 1/28/2022 11:56:27.89
*/
gx.evt.autoSkip=!1;gx.define("catalog_de_tipo_doc",!1,function(){this.ServerClass="catalog_de_tipo_doc";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.A40000GXC1=gx.fn.getIntegerValue("GXC1",".");this.AV7tipodocumento=gx.fn.getControlValue("vTIPODOCUMENTO");this.Gx_date=gx.fn.getDateValue("vTODAY")};this.e120y2_client=function(){this.executeServerEvent("'GUARDAR '",!1,null,!1,!1)};this.e130y2_client=function(){this.executeServerEvent("'CANCELAR'",!1,null,!1,!1)};this.e140y2_client=function(){this.executeServerEvent("'CONSULTAR '",!1,null,!1,!1)};this.e160y2_client=function(){this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e170y2_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[3,8,12,16,17];this.GXLastCtrlId=17;n[3]={fld:"TABLE1",grid:0};n[8]={fld:"TABLE2",grid:0};n[12]={lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vNEXTVALUE",gxz:"ZV6NextValue",gxold:"OV6NextValue",gxvar:"AV6NextValue",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6NextValue=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6NextValue=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vNEXTVALUE",gx.O.AV6NextValue,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6NextValue=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vNEXTVALUE",".")},nac:gx.falseFn};n[16]={lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vTIPODOCUMENTODSC",gxz:"ZV8tipodocumentodsc",gxold:"OV8tipodocumentodsc",gxvar:"AV8tipodocumentodsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8tipodocumentodsc=n)},v2z:function(n){n!==undefined&&(gx.O.ZV8tipodocumentodsc=n)},v2c:function(){gx.fn.setControlValue("vTIPODOCUMENTODSC",gx.O.AV8tipodocumentodsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8tipodocumentodsc=this.val())},val:function(){return gx.fn.getControlValue("vTIPODOCUMENTODSC")},nac:gx.falseFn};n[17]={fld:"TABLE3",grid:0};this.AV6NextValue=0;this.ZV6NextValue=0;this.OV6NextValue=0;this.AV8tipodocumentodsc="";this.ZV8tipodocumentodsc="";this.OV8tipodocumentodsc="";this.AV6NextValue=0;this.AV8tipodocumentodsc="";this.AV7tipodocumento={};this.Gx_date=gx.date.nullDate();this.Events={e120y2_client:["'GUARDAR '",!0],e130y2_client:["'CANCELAR'",!0],e140y2_client:["'CONSULTAR '",!0],e160y2_client:["ENTER",!0],e170y2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[],[]];this.EvtParms["'GUARDAR '"]=[[{av:"AV6NextValue",fld:"vNEXTVALUE",pic:"ZZZ9",hsh:!0,nv:0},{av:"AV7tipodocumento",fld:"vTIPODOCUMENTO",pic:"",nv:null},{av:"AV8tipodocumentodsc",fld:"vTIPODOCUMENTODSC",pic:"",nv:""},{av:"Gx_date",fld:"vTODAY",pic:"",nv:""}],[{av:"AV7tipodocumento",fld:"vTIPODOCUMENTO",pic:"",nv:null}]];this.EvtParms["'CANCELAR'"]=[[],[]];this.EvtParms["'CONSULTAR '"]=[[],[]];this.setVCMap("A40000GXC1","GXC1",0,"int");this.setVCMap("AV7tipodocumento","vTIPODOCUMENTO",0,"tipodocumento");this.setVCMap("Gx_date","vTODAY",0,"date");this.InitStandaloneVars()});gx.createParentObj(catalog_de_tipo_doc)