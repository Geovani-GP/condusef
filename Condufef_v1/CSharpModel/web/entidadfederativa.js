/**@preserve  GeneXus C# 10_3_15-115824 on 1/26/2022 20:7:16.57
*/
gx.evt.autoSkip=!1;gx.define("entidadfederativa",!1,function(){this.ServerClass="entidadfederativa";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Entidafederativaid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Entidafederativaid",["gx.O.A7entidafederativaid","gx.O.A108entidadfederativadsc","gx.O.A109entidadfederativausuario",'gx.date.urlDateTime(gx.O.A110entidadfederativafecreg,"DMY")','gx.date.urlDateTime(gx.O.A111entidadfederativafecultact,"DMY")'],["A108entidadfederativadsc","A109entidadfederativausuario","A110entidadfederativafecreg","A111entidadfederativafecultact","Gx_mode","Z7entidafederativaid","Z108entidadfederativadsc","Z109entidadfederativausuario","Z110entidadfederativafecreg","Z111entidadfederativafecultact",["BTN_DELETE","Enabled"],["BTN_ENTER","Enabled"]]),!0};this.e11044_client=function(){this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e12044_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,16,17,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41];this.GXLastCtrlId=41;n[2]={fld:"",grid:0};n[3]={fld:"TABLEMAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"TITLE",format:0,grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"",grid:0};n[10]={fld:"",grid:0};n[16]={fld:"",grid:0};n[17]={fld:"",grid:0};n[19]={fld:"",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Entidafederativaid,isvalid:null,rgrid:[],fld:"ENTIDAFEDERATIVAID",gxz:"Z7entidafederativaid",gxold:"O7entidafederativaid",gxvar:"A7entidafederativaid",ucs:[],op:[38,34,30,26],ip:[38,34,30,26,22],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A7entidafederativaid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z7entidafederativaid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ENTIDAFEDERATIVAID",gx.O.A7entidafederativaid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A7entidafederativaid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ENTIDAFEDERATIVAID",".")},nac:gx.falseFn};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ENTIDADFEDERATIVADSC",gxz:"Z108entidadfederativadsc",gxold:"O108entidadfederativadsc",gxvar:"A108entidadfederativadsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A108entidadfederativadsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z108entidadfederativadsc=n)},v2c:function(){gx.fn.setControlValue("ENTIDADFEDERATIVADSC",gx.O.A108entidadfederativadsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A108entidadfederativadsc=this.val())},val:function(){return gx.fn.getControlValue("ENTIDADFEDERATIVADSC")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"",grid:0};n[30]={lvl:0,type:"svchar",len:15,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ENTIDADFEDERATIVAUSUARIO",gxz:"Z109entidadfederativausuario",gxold:"O109entidadfederativausuario",gxvar:"A109entidadfederativausuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A109entidadfederativausuario=n)},v2z:function(n){n!==undefined&&(gx.O.Z109entidadfederativausuario=n)},v2c:function(){gx.fn.setControlValue("ENTIDADFEDERATIVAUSUARIO",gx.O.A109entidadfederativausuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.A109entidadfederativausuario=this.val())},val:function(){return gx.fn.getControlValue("ENTIDADFEDERATIVAUSUARIO")},nac:gx.falseFn};n[31]={fld:"",grid:0};n[32]={fld:"",grid:0};n[33]={fld:"",grid:0};n[34]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ENTIDADFEDERATIVAFECREG",gxz:"Z110entidadfederativafecreg",gxold:"O110entidadfederativafecreg",gxvar:"A110entidadfederativafecreg",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A110entidadfederativafecreg=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z110entidadfederativafecreg=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("ENTIDADFEDERATIVAFECREG",gx.O.A110entidadfederativafecreg,0)},c2v:function(){this.val()!==undefined&&(gx.O.A110entidadfederativafecreg=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("ENTIDADFEDERATIVAFECREG")},nac:gx.falseFn};n[35]={fld:"",grid:0};n[36]={fld:"",grid:0};n[37]={fld:"",grid:0};n[38]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ENTIDADFEDERATIVAFECULTACT",gxz:"Z111entidadfederativafecultact",gxold:"O111entidadfederativafecultact",gxvar:"A111entidadfederativafecultact",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A111entidadfederativafecultact=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z111entidadfederativafecultact=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("ENTIDADFEDERATIVAFECULTACT",gx.O.A111entidadfederativafecultact,0)},c2v:function(){this.val()!==undefined&&(gx.O.A111entidadfederativafecultact=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("ENTIDADFEDERATIVAFECULTACT")},nac:gx.falseFn};n[39]={fld:"",grid:0};n[40]={fld:"",grid:0};n[41]={fld:"",grid:0};this.A7entidafederativaid=0;this.Z7entidafederativaid=0;this.O7entidafederativaid=0;this.A108entidadfederativadsc="";this.Z108entidadfederativadsc="";this.O108entidadfederativadsc="";this.A109entidadfederativausuario="";this.Z109entidadfederativausuario="";this.O109entidadfederativausuario="";this.A110entidadfederativafecreg=gx.date.nullDate();this.Z110entidadfederativafecreg=gx.date.nullDate();this.O110entidadfederativafecreg=gx.date.nullDate();this.A111entidadfederativafecultact=gx.date.nullDate();this.Z111entidadfederativafecultact=gx.date.nullDate();this.O111entidadfederativafecultact=gx.date.nullDate();this.A7entidafederativaid=0;this.A108entidadfederativadsc="";this.A109entidadfederativausuario="";this.A110entidadfederativafecreg=gx.date.nullDate();this.A111entidadfederativafecultact=gx.date.nullDate();this.Events={e11044_client:["ENTER",!0],e12044_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0}],[]];this.EvtParms.REFRESH=[[],[]];this.EnterCtrl=["BTN_ENTER"];this.setVCMap("Gx_mode","vMODE",0,"char");this.InitStandaloneVars()});gx.createParentObj(entidadfederativa)