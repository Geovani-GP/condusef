/**@preserve  GeneXus C# 10_3_15-115824 on 2/5/2022 1:35:47.52
*/
gx.evt.autoSkip=!1;gx.define("login",!1,function(){var t,n;this.ServerClass="login";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.A173usuario=gx.fn.getControlValue("USUARIO");this.A174contrasena=gx.fn.getControlValue("CONTRASENA")};this.e110s2_client=function(){this.executeServerEvent("'INICIAR SESIÓN '",!1,null,!1,!1)};this.e120s2_client=function(){this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e150s2_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];t=this.GXValidFnc;this.GXCtrlIds=[3,6,10,14,21];this.GXLastCtrlId=21;this.HUGAOMESSAGES1Container=gx.uc.getNew(this,26,14,"HugaoMessages","HUGAOMESSAGES1Container","Hugaomessages1");n=this.HUGAOMESSAGES1Container;n.setProp("Type","Type","jgrowl","str");n.setProp("Visible","Visible",!0,"bool");n.setProp("Enabled","Enabled",!0,"boolean");n.setProp("Class","Class","","char");n.setC2ShowFunction(function(n){n.show()});this.setUserControl(n);t[3]={fld:"TABLE1",grid:0};t[6]={fld:"TABLE2",grid:0};t[10]={fld:"IMAGE1",grid:0};t[14]={lvl:0,type:"svchar",len:25,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vUSUARIO",gxz:"ZV5usuario",gxold:"OV5usuario",gxvar:"AV5usuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV5usuario=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5usuario=n)},v2c:function(){gx.fn.setControlValue("vUSUARIO",gx.O.AV5usuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV5usuario=this.val())},val:function(){return gx.fn.getControlValue("vUSUARIO")},nac:gx.falseFn};t[21]={lvl:0,type:"svchar",len:10,dec:0,sign:!1,isPwd:!0,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vCONTRASENA",gxz:"ZV6contrasena",gxold:"OV6contrasena",gxvar:"AV6contrasena",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6contrasena=n)},v2z:function(n){n!==undefined&&(gx.O.ZV6contrasena=n)},v2c:function(){gx.fn.setControlValue("vCONTRASENA",gx.O.AV6contrasena,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6contrasena=this.val())},val:function(){return gx.fn.getControlValue("vCONTRASENA")},nac:gx.falseFn};this.AV5usuario="";this.ZV5usuario="";this.OV5usuario="";this.AV6contrasena="";this.ZV6contrasena="";this.OV6contrasena="";this.AV5usuario="";this.AV6contrasena="";this.A173usuario="";this.A174contrasena="";this.Events={e110s2_client:["'INICIAR SESIÓN '",!0],e120s2_client:["ENTER",!0],e150s2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[],[]];this.EvtParms["'INICIAR SESIÓN '"]=[[{av:"AV5usuario",fld:"vUSUARIO",pic:"",nv:""},{av:"AV6contrasena",fld:"vCONTRASENA",pic:"",nv:""},{av:"A173usuario",fld:"USUARIO",pic:"",nv:""},{av:"A174contrasena",fld:"CONTRASENA",pic:"",nv:""}],[]];this.EvtParms.ENTER=[[{av:"A173usuario",fld:"USUARIO",pic:"",nv:""},{av:"AV5usuario",fld:"vUSUARIO",pic:"",nv:""},{av:"A174contrasena",fld:"CONTRASENA",pic:"",nv:""},{av:"AV6contrasena",fld:"vCONTRASENA",pic:"",nv:""}],[]];this.setVCMap("A173usuario","USUARIO",0,"svchar");this.setVCMap("A174contrasena","CONTRASENA",0,"svchar");this.InitStandaloneVars();this.setComponent({id:"WEBCOMP1",GXClass:"alerts",Prefix:"W0027",lvl:1})});gx.createParentObj(login)