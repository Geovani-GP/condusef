/**@preserve  GeneXus C# 10_3_15-115824 on 1/25/2022 21:15:13.15
*/
gx.evt.autoSkip=!1;gx.define("appmasterpage",!1,function(){this.ServerClass="appmasterpage";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.IsMasterPage=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.e13012_client=function(){this.executeServerEvent("ENTER_MPAGE",!0,null,!1,!1)};this.e14012_client=function(){this.executeServerEvent("CANCEL_MPAGE",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,5,8,11,13,14,15,16,20];this.GXLastCtrlId=20;n[2]={fld:"TABLE1",grid:0};n[5]={fld:"TABLE2",grid:0};n[8]={fld:"IMAGE1",grid:0};n[11]={lvl:0,type:"svchar",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vTITULO_MPAGE",gxz:"ZV11Titulo",gxold:"OV11Titulo",gxvar:"AV11Titulo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV11Titulo=n)},v2z:function(n){n!==undefined&&(gx.O.ZV11Titulo=n)},v2c:function(){gx.fn.setControlValue("vTITULO_MPAGE",gx.O.AV11Titulo,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV11Titulo=this.val())},val:function(){return gx.fn.getControlValue("vTITULO_MPAGE")},nac:gx.falseFn};n[13]={fld:"TEXTBLOCK2",format:0,grid:0};n[14]={lvl:0,type:"svchar",len:25,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vUSUARIO_MPAGE",gxz:"ZV8usuario",gxold:"OV8usuario",gxvar:"AV8usuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8usuario=n)},v2z:function(n){n!==undefined&&(gx.O.ZV8usuario=n)},v2c:function(){gx.fn.setControlValue("vUSUARIO_MPAGE",gx.O.AV8usuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8usuario=this.val())},val:function(){return gx.fn.getControlValue("vUSUARIO_MPAGE")},nac:gx.falseFn};n[15]={fld:"TEXTBLOCK1",format:0,grid:0};n[16]={lvl:0,type:"char",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vFECHA_MPAGE",gxz:"ZV10fecha",gxold:"OV10fecha",gxvar:"AV10fecha",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10fecha=n)},v2z:function(n){n!==undefined&&(gx.O.ZV10fecha=n)},v2c:function(){gx.fn.setControlValue("vFECHA_MPAGE",gx.O.AV10fecha,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV10fecha=this.val())},val:function(){return gx.fn.getControlValue("vFECHA_MPAGE")},nac:gx.falseFn};n[20]={fld:"TABLE3",grid:0};this.AV11Titulo="";this.ZV11Titulo="";this.OV11Titulo="";this.AV8usuario="";this.ZV8usuario="";this.OV8usuario="";this.AV10fecha="";this.ZV10fecha="";this.OV10fecha="";this.AV11Titulo="";this.AV8usuario="";this.AV10fecha="";this.Events={e13012_client:["ENTER_MPAGE",!0],e14012_client:["CANCEL_MPAGE",!0]};this.EvtParms.REFRESH_MPAGE=[[],[]];this.InitStandaloneVars();this.setComponent({id:"WEBCOMP1",GXClass:"sidebar",Prefix:"MPW0023",lvl:1})});gx.createMasterPage(appmasterpage)