/**@preserve  GeneXus C# 10_3_15-115824 on 1/29/2022 1:0:43.31
*/
gx.evt.autoSkip=!1;gx.define("tipobien",!1,function(){this.ServerClass="tipobien";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Tipobienid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Tipobienid",["gx.O.A23tipobienid","gx.O.A139tipobiendsc","gx.O.A140tipobienusuario",'gx.date.urlDate(gx.O.A141tipobienfecreg,"DMY")','gx.date.urlDate(gx.O.A142tipobienfecultact,"DMY")'],["A139tipobiendsc","A140tipobienusuario","A141tipobienfecreg","A142tipobienfecultact","Gx_mode","Z23tipobienid","Z139tipobiendsc","Z140tipobienusuario","Z141tipobienfecreg","Z142tipobienfecultact",["BTN_DELETE","Enabled"],["BTN_ENTER","Enabled"]]),!0};this.e11011_client=function(){this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e12011_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,16,17,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41];this.GXLastCtrlId=41;n[2]={fld:"",grid:0};n[3]={fld:"TABLEMAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"TITLE",format:0,grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"",grid:0};n[10]={fld:"",grid:0};n[16]={fld:"",grid:0};n[17]={fld:"",grid:0};n[19]={fld:"",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Tipobienid,isvalid:null,rgrid:[],fld:"TIPOBIENID",gxz:"Z23tipobienid",gxold:"O23tipobienid",gxvar:"A23tipobienid",ucs:[],op:[38,34,30,26],ip:[38,34,30,26,22],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A23tipobienid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z23tipobienid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("TIPOBIENID",gx.O.A23tipobienid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A23tipobienid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("TIPOBIENID",".")},nac:gx.falseFn};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"TIPOBIENDSC",gxz:"Z139tipobiendsc",gxold:"O139tipobiendsc",gxvar:"A139tipobiendsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A139tipobiendsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z139tipobiendsc=n)},v2c:function(){gx.fn.setControlValue("TIPOBIENDSC",gx.O.A139tipobiendsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A139tipobiendsc=this.val())},val:function(){return gx.fn.getControlValue("TIPOBIENDSC")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"",grid:0};n[30]={lvl:0,type:"svchar",len:15,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"TIPOBIENUSUARIO",gxz:"Z140tipobienusuario",gxold:"O140tipobienusuario",gxvar:"A140tipobienusuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A140tipobienusuario=n)},v2z:function(n){n!==undefined&&(gx.O.Z140tipobienusuario=n)},v2c:function(){gx.fn.setControlValue("TIPOBIENUSUARIO",gx.O.A140tipobienusuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.A140tipobienusuario=this.val())},val:function(){return gx.fn.getControlValue("TIPOBIENUSUARIO")},nac:gx.falseFn};n[31]={fld:"",grid:0};n[32]={fld:"",grid:0};n[33]={fld:"",grid:0};n[34]={lvl:0,type:"date",len:10,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"TIPOBIENFECREG",gxz:"Z141tipobienfecreg",gxold:"O141tipobienfecreg",gxvar:"A141tipobienfecreg",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A141tipobienfecreg=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z141tipobienfecreg=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("TIPOBIENFECREG",gx.O.A141tipobienfecreg,0)},c2v:function(){this.val()!==undefined&&(gx.O.A141tipobienfecreg=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getControlValue("TIPOBIENFECREG")},nac:gx.falseFn};n[35]={fld:"",grid:0};n[36]={fld:"",grid:0};n[37]={fld:"",grid:0};n[38]={lvl:0,type:"date",len:10,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"TIPOBIENFECULTACT",gxz:"Z142tipobienfecultact",gxold:"O142tipobienfecultact",gxvar:"A142tipobienfecultact",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A142tipobienfecultact=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z142tipobienfecultact=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("TIPOBIENFECULTACT",gx.O.A142tipobienfecultact,0)},c2v:function(){this.val()!==undefined&&(gx.O.A142tipobienfecultact=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getControlValue("TIPOBIENFECULTACT")},nac:gx.falseFn};n[39]={fld:"",grid:0};n[40]={fld:"",grid:0};n[41]={fld:"",grid:0};this.A23tipobienid=0;this.Z23tipobienid=0;this.O23tipobienid=0;this.A139tipobiendsc="";this.Z139tipobiendsc="";this.O139tipobiendsc="";this.A140tipobienusuario="";this.Z140tipobienusuario="";this.O140tipobienusuario="";this.A141tipobienfecreg=gx.date.nullDate();this.Z141tipobienfecreg=gx.date.nullDate();this.O141tipobienfecreg=gx.date.nullDate();this.A142tipobienfecultact=gx.date.nullDate();this.Z142tipobienfecultact=gx.date.nullDate();this.O142tipobienfecultact=gx.date.nullDate();this.A23tipobienid=0;this.A139tipobiendsc="";this.A140tipobienusuario="";this.A141tipobienfecreg=gx.date.nullDate();this.A142tipobienfecultact=gx.date.nullDate();this.Events={e11011_client:["ENTER",!0],e12011_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0}],[]];this.EvtParms.REFRESH=[[],[]];this.EnterCtrl=["BTN_ENTER"];this.setVCMap("Gx_mode","vMODE",0,"char");this.InitStandaloneVars()});gx.createParentObj(tipobien)