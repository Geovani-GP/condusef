/**@preserve  GeneXus C# 10_3_15-115824 on 1/28/2022 1:40:56.46
*/
gx.evt.autoSkip=!1;gx.define("status",!1,function(){this.ServerClass="status";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Statusid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Statusid",["gx.O.A1statusid","gx.O.A73statusdsc","gx.O.A74statususotabla","gx.O.A75statusdesc","gx.O.A76statususuario",'gx.date.urlDateTime(gx.O.A77statusfecreg,"DMY")','gx.date.urlDateTime(gx.O.A78statusfecultact,"DMY")'],["A73statusdsc","A74statususotabla","A75statusdesc","A76statususuario","A77statusfecreg","A78statusfecultact","Gx_mode","Z1statusid","Z73statusdsc","Z74statususotabla","Z75statusdesc","Z76statususuario","Z77statusfecreg","Z78statusfecultact",["BTN_DELETE","Enabled"],["BTN_ENTER","Enabled"]]),!0};this.e110l21_client=function(){this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e120l21_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,16,17,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49];this.GXLastCtrlId=49;n[2]={fld:"",grid:0};n[3]={fld:"TABLEMAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"TITLE",format:0,grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"",grid:0};n[10]={fld:"",grid:0};n[16]={fld:"",grid:0};n[17]={fld:"",grid:0};n[19]={fld:"",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Statusid,isvalid:null,rgrid:[],fld:"STATUSID",gxz:"Z1statusid",gxold:"O1statusid",gxvar:"A1statusid",ucs:[],op:[46,42,38,34,30,26],ip:[46,42,38,34,30,26,22],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A1statusid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1statusid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("STATUSID",gx.O.A1statusid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A1statusid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("STATUSID",".")},nac:gx.falseFn};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"svchar",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"STATUSDSC",gxz:"Z73statusdsc",gxold:"O73statusdsc",gxvar:"A73statusdsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A73statusdsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z73statusdsc=n)},v2c:function(){gx.fn.setControlValue("STATUSDSC",gx.O.A73statusdsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A73statusdsc=this.val())},val:function(){return gx.fn.getControlValue("STATUSDSC")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"",grid:0};n[30]={lvl:0,type:"svchar",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"STATUSUSOTABLA",gxz:"Z74statususotabla",gxold:"O74statususotabla",gxvar:"A74statususotabla",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A74statususotabla=n)},v2z:function(n){n!==undefined&&(gx.O.Z74statususotabla=n)},v2c:function(){gx.fn.setControlValue("STATUSUSOTABLA",gx.O.A74statususotabla,0)},c2v:function(){this.val()!==undefined&&(gx.O.A74statususotabla=this.val())},val:function(){return gx.fn.getControlValue("STATUSUSOTABLA")},nac:gx.falseFn};n[31]={fld:"",grid:0};n[32]={fld:"",grid:0};n[33]={fld:"",grid:0};n[34]={lvl:0,type:"svchar",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"STATUSDESC",gxz:"Z75statusdesc",gxold:"O75statusdesc",gxvar:"A75statusdesc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A75statusdesc=n)},v2z:function(n){n!==undefined&&(gx.O.Z75statusdesc=n)},v2c:function(){gx.fn.setControlValue("STATUSDESC",gx.O.A75statusdesc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A75statusdesc=this.val())},val:function(){return gx.fn.getControlValue("STATUSDESC")},nac:gx.falseFn};n[35]={fld:"",grid:0};n[36]={fld:"",grid:0};n[37]={fld:"",grid:0};n[38]={lvl:0,type:"svchar",len:15,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"STATUSUSUARIO",gxz:"Z76statususuario",gxold:"O76statususuario",gxvar:"A76statususuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A76statususuario=n)},v2z:function(n){n!==undefined&&(gx.O.Z76statususuario=n)},v2c:function(){gx.fn.setControlValue("STATUSUSUARIO",gx.O.A76statususuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.A76statususuario=this.val())},val:function(){return gx.fn.getControlValue("STATUSUSUARIO")},nac:gx.falseFn};n[39]={fld:"",grid:0};n[40]={fld:"",grid:0};n[41]={fld:"",grid:0};n[42]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"STATUSFECREG",gxz:"Z77statusfecreg",gxold:"O77statusfecreg",gxvar:"A77statusfecreg",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A77statusfecreg=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z77statusfecreg=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("STATUSFECREG",gx.O.A77statusfecreg,0)},c2v:function(){this.val()!==undefined&&(gx.O.A77statusfecreg=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("STATUSFECREG")},nac:gx.falseFn};n[43]={fld:"",grid:0};n[44]={fld:"",grid:0};n[45]={fld:"",grid:0};n[46]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"STATUSFECULTACT",gxz:"Z78statusfecultact",gxold:"O78statusfecultact",gxvar:"A78statusfecultact",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A78statusfecultact=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z78statusfecultact=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("STATUSFECULTACT",gx.O.A78statusfecultact,0)},c2v:function(){this.val()!==undefined&&(gx.O.A78statusfecultact=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("STATUSFECULTACT")},nac:gx.falseFn};n[47]={fld:"",grid:0};n[48]={fld:"",grid:0};n[49]={fld:"",grid:0};this.A1statusid=0;this.Z1statusid=0;this.O1statusid=0;this.A73statusdsc="";this.Z73statusdsc="";this.O73statusdsc="";this.A74statususotabla="";this.Z74statususotabla="";this.O74statususotabla="";this.A75statusdesc="";this.Z75statusdesc="";this.O75statusdesc="";this.A76statususuario="";this.Z76statususuario="";this.O76statususuario="";this.A77statusfecreg=gx.date.nullDate();this.Z77statusfecreg=gx.date.nullDate();this.O77statusfecreg=gx.date.nullDate();this.A78statusfecultact=gx.date.nullDate();this.Z78statusfecultact=gx.date.nullDate();this.O78statusfecultact=gx.date.nullDate();this.A1statusid=0;this.A73statusdsc="";this.A74statususotabla="";this.A75statusdesc="";this.A76statususuario="";this.A77statusfecreg=gx.date.nullDate();this.A78statusfecultact=gx.date.nullDate();this.Events={e110l21_client:["ENTER",!0],e120l21_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0}],[]];this.EvtParms.REFRESH=[[],[]];this.EnterCtrl=["BTN_ENTER"];this.setVCMap("Gx_mode","vMODE",0,"char");this.InitStandaloneVars()});gx.createParentObj(status)