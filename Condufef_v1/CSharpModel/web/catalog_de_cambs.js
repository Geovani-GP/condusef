/**@preserve  GeneXus C# 10_3_15-115824 on 2/5/2022 21:4:59.12
*/
gx.evt.autoSkip=!1;gx.define("catalog_de_cambs",!1,function(){this.ServerClass="catalog_de_cambs";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.A40000GXC1=gx.fn.getIntegerValue("GXC1",".");this.AV9cambs=gx.fn.getControlValue("vCAMBS");this.Gx_date=gx.fn.getDateValue("vTODAY")};this.e120u2_client=function(){this.executeServerEvent("'GUARDAR '",!1,null,!1,!1)};this.e130u2_client=function(){this.executeServerEvent("'CONSULTAR '",!1,null,!1,!1)};this.e140u2_client=function(){this.executeServerEvent("'CANCELAR'",!1,null,!1,!1)};this.e160u2_client=function(){this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e170u2_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,5,8,12,16,17];this.GXLastCtrlId=17;n[2]={fld:"TABLE1",grid:0};n[5]={fld:"TEXTBLOCK8",format:0,grid:0};n[8]={fld:"TABLE2",grid:0};n[12]={lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vNEXTVALUE",gxz:"ZV6NextValue",gxold:"OV6NextValue",gxvar:"AV6NextValue",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6NextValue=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6NextValue=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vNEXTVALUE",gx.O.AV6NextValue,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6NextValue=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vNEXTVALUE",".")},nac:gx.falseFn};n[16]={lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vCAMBSDSC",gxz:"ZV8cambsdsc",gxold:"OV8cambsdsc",gxvar:"AV8cambsdsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8cambsdsc=n)},v2z:function(n){n!==undefined&&(gx.O.ZV8cambsdsc=n)},v2c:function(){gx.fn.setControlValue("vCAMBSDSC",gx.O.AV8cambsdsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8cambsdsc=this.val())},val:function(){return gx.fn.getControlValue("vCAMBSDSC")},nac:gx.falseFn};n[17]={fld:"TABLE3",grid:0};this.AV6NextValue=0;this.ZV6NextValue=0;this.OV6NextValue=0;this.AV8cambsdsc="";this.ZV8cambsdsc="";this.OV8cambsdsc="";this.AV6NextValue=0;this.AV8cambsdsc="";this.AV9cambs={};this.Gx_date=gx.date.nullDate();this.Events={e120u2_client:["'GUARDAR '",!0],e130u2_client:["'CONSULTAR '",!0],e140u2_client:["'CANCELAR'",!0],e160u2_client:["ENTER",!0],e170u2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[],[]];this.EvtParms["'GUARDAR '"]=[[{av:"AV8cambsdsc",fld:"vCAMBSDSC",pic:"",nv:""},{av:"AV6NextValue",fld:"vNEXTVALUE",pic:"ZZZ9",hsh:!0,nv:0},{av:"AV9cambs",fld:"vCAMBS",pic:"",nv:null},{av:"Gx_date",fld:"vTODAY",pic:"",nv:""}],[{av:"AV9cambs",fld:"vCAMBS",pic:"",nv:null}]];this.EvtParms["'CONSULTAR '"]=[[],[]];this.EvtParms["'CANCELAR'"]=[[],[]];this.setVCMap("A40000GXC1","GXC1",0,"int");this.setVCMap("AV9cambs","vCAMBS",0,"cambs");this.setVCMap("Gx_date","vTODAY",0,"date");this.InitStandaloneVars()});gx.createParentObj(catalog_de_cambs)