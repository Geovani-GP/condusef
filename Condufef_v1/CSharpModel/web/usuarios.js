/**@preserve  GeneXus C# 10_3_15-115824 on 2/15/2022 5:9:4.92
*/
gx.evt.autoSkip=!1;gx.define("usuarios",!1,function(){this.ServerClass="usuarios";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Idusuario=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Idusuario",["gx.O.A9idusuario","gx.O.A173usuario","gx.O.A174contrasena"],["A173usuario","A174contrasena","Gx_mode","Z9idusuario","Z173usuario","Z174contrasena",["BTN_DELETE","Enabled"],["BTN_ENTER","Enabled"]]),!0};this.e110f15_client=function(){this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e120f15_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,16,17,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33];this.GXLastCtrlId=33;n[2]={fld:"",grid:0};n[3]={fld:"TABLEMAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"TITLE",format:0,grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"",grid:0};n[10]={fld:"",grid:0};n[16]={fld:"",grid:0};n[17]={fld:"",grid:0};n[19]={fld:"",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Idusuario,isvalid:null,rgrid:[],fld:"IDUSUARIO",gxz:"Z9idusuario",gxold:"O9idusuario",gxvar:"A9idusuario",ucs:[],op:[30,26],ip:[30,26,22],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A9idusuario=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z9idusuario=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("IDUSUARIO",gx.O.A9idusuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.A9idusuario=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("IDUSUARIO",".")},nac:gx.falseFn};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"svchar",len:25,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"USUARIO",gxz:"Z173usuario",gxold:"O173usuario",gxvar:"A173usuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A173usuario=n)},v2z:function(n){n!==undefined&&(gx.O.Z173usuario=n)},v2c:function(){gx.fn.setControlValue("USUARIO",gx.O.A173usuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.A173usuario=this.val())},val:function(){return gx.fn.getControlValue("USUARIO")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"",grid:0};n[30]={lvl:0,type:"svchar",len:10,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"CONTRASENA",gxz:"Z174contrasena",gxold:"O174contrasena",gxvar:"A174contrasena",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A174contrasena=n)},v2z:function(n){n!==undefined&&(gx.O.Z174contrasena=n)},v2c:function(){gx.fn.setControlValue("CONTRASENA",gx.O.A174contrasena,0)},c2v:function(){this.val()!==undefined&&(gx.O.A174contrasena=this.val())},val:function(){return gx.fn.getControlValue("CONTRASENA")},nac:gx.falseFn};n[31]={fld:"",grid:0};n[32]={fld:"",grid:0};n[33]={fld:"",grid:0};this.A9idusuario=0;this.Z9idusuario=0;this.O9idusuario=0;this.A173usuario="";this.Z173usuario="";this.O173usuario="";this.A174contrasena="";this.Z174contrasena="";this.O174contrasena="";this.A9idusuario=0;this.A173usuario="";this.A174contrasena="";this.Events={e110f15_client:["ENTER",!0],e120f15_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0}],[]];this.EvtParms.REFRESH=[[],[]];this.EnterCtrl=["BTN_ENTER"];this.setVCMap("Gx_mode","vMODE",0,"char");this.InitStandaloneVars()});gx.createParentObj(usuarios)