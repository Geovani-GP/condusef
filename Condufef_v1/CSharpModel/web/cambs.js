/**@preserve  GeneXus C# 10_3_15-115824 on 1/22/2022 13:27:30.26
*/
gx.evt.autoSkip=!1;gx.define("cambs",!1,function(){this.ServerClass="cambs";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Cambsid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Cambsid",["gx.O.A25cambsid","gx.O.A83cambsdsc","gx.O.A84cambsusuario",'gx.date.urlDateTime(gx.O.A85cambsfecreg,"DMY")','gx.date.urlDateTime(gx.O.A86cambsfecultact,"DMY")'],["A83cambsdsc","A84cambsusuario","A85cambsfecreg","A86cambsfecultact","Gx_mode","Z25cambsid","Z83cambsdsc","Z84cambsusuario","Z85cambsfecreg","Z86cambsfecultact",["BTN_DELETE","Enabled"],["BTN_ENTER","Enabled"]]),!0};this.e110e14_client=function(){this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e120e14_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,16,17,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41];this.GXLastCtrlId=41;n[2]={fld:"",grid:0};n[3]={fld:"TABLEMAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"TITLE",format:0,grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"",grid:0};n[10]={fld:"",grid:0};n[16]={fld:"",grid:0};n[17]={fld:"",grid:0};n[19]={fld:"",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Cambsid,isvalid:null,rgrid:[],fld:"CAMBSID",gxz:"Z25cambsid",gxold:"O25cambsid",gxvar:"A25cambsid",ucs:[],op:[38,34,30,26],ip:[38,34,30,26,22],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A25cambsid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z25cambsid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("CAMBSID",gx.O.A25cambsid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A25cambsid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("CAMBSID",".")},nac:gx.falseFn};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"CAMBSDSC",gxz:"Z83cambsdsc",gxold:"O83cambsdsc",gxvar:"A83cambsdsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A83cambsdsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z83cambsdsc=n)},v2c:function(){gx.fn.setControlValue("CAMBSDSC",gx.O.A83cambsdsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A83cambsdsc=this.val())},val:function(){return gx.fn.getControlValue("CAMBSDSC")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"",grid:0};n[30]={lvl:0,type:"svchar",len:15,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"CAMBSUSUARIO",gxz:"Z84cambsusuario",gxold:"O84cambsusuario",gxvar:"A84cambsusuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A84cambsusuario=n)},v2z:function(n){n!==undefined&&(gx.O.Z84cambsusuario=n)},v2c:function(){gx.fn.setControlValue("CAMBSUSUARIO",gx.O.A84cambsusuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.A84cambsusuario=this.val())},val:function(){return gx.fn.getControlValue("CAMBSUSUARIO")},nac:gx.falseFn};n[31]={fld:"",grid:0};n[32]={fld:"",grid:0};n[33]={fld:"",grid:0};n[34]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"CAMBSFECREG",gxz:"Z85cambsfecreg",gxold:"O85cambsfecreg",gxvar:"A85cambsfecreg",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A85cambsfecreg=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z85cambsfecreg=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("CAMBSFECREG",gx.O.A85cambsfecreg,0)},c2v:function(){this.val()!==undefined&&(gx.O.A85cambsfecreg=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("CAMBSFECREG")},nac:gx.falseFn};n[35]={fld:"",grid:0};n[36]={fld:"",grid:0};n[37]={fld:"",grid:0};n[38]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"CAMBSFECULTACT",gxz:"Z86cambsfecultact",gxold:"O86cambsfecultact",gxvar:"A86cambsfecultact",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A86cambsfecultact=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z86cambsfecultact=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("CAMBSFECULTACT",gx.O.A86cambsfecultact,0)},c2v:function(){this.val()!==undefined&&(gx.O.A86cambsfecultact=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("CAMBSFECULTACT")},nac:gx.falseFn};n[39]={fld:"",grid:0};n[40]={fld:"",grid:0};n[41]={fld:"",grid:0};this.A25cambsid=0;this.Z25cambsid=0;this.O25cambsid=0;this.A83cambsdsc="";this.Z83cambsdsc="";this.O83cambsdsc="";this.A84cambsusuario="";this.Z84cambsusuario="";this.O84cambsusuario="";this.A85cambsfecreg=gx.date.nullDate();this.Z85cambsfecreg=gx.date.nullDate();this.O85cambsfecreg=gx.date.nullDate();this.A86cambsfecultact=gx.date.nullDate();this.Z86cambsfecultact=gx.date.nullDate();this.O86cambsfecultact=gx.date.nullDate();this.A25cambsid=0;this.A83cambsdsc="";this.A84cambsusuario="";this.A85cambsfecreg=gx.date.nullDate();this.A86cambsfecultact=gx.date.nullDate();this.Events={e110e14_client:["ENTER",!0],e120e14_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0}],[]];this.EvtParms.REFRESH=[[],[]];this.EnterCtrl=["BTN_ENTER"];this.setVCMap("Gx_mode","vMODE",0,"char");this.InitStandaloneVars()});gx.createParentObj(cambs)