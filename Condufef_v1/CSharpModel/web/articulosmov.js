/**@preserve  GeneXus C# 10_3_15-115824 on 1/25/2022 17:34:41.65
*/
gx.evt.autoSkip=!1;gx.define("articulosmov",!1,function(){this.ServerClass="articulosmov";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Articulosmovid=function(){try{var n=gx.util.balloon.getNew("ARTICULOSMOVID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Articulosmovproductoid=function(){try{var n=gx.util.balloon.getNew("ARTICULOSMOVPRODUCTOID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Articulosmovcambsid=function(){try{var n=gx.util.balloon.getNew("ARTICULOSMOVCAMBSID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.Valid_Articulosmovarticuloid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Articulosmovarticuloid",["gx.O.A3articulosmovid","gx.O.A4articulosmovproductoid","gx.O.A5articulosmovcambsid","gx.num.urlDecimal(gx.O.A6articulosmovarticuloid,'.',',')","gx.num.urlDecimal(gx.O.A39articulosmovdepositario,'.',',')",'gx.date.urlDateTime(gx.O.A40articulosmovfechamov,"DMY")',"gx.num.urlDecimal(gx.O.A41articulosmovstatus,'.',',')","gx.O.A42articulosmovagregomovsist","gx.O.A43articulosmovususuario",'gx.date.urlDateTime(gx.O.A44articulosmovfecreg,"DMY")','gx.date.urlDateTime(gx.O.A45articulosmovfecultact,"DMY")'],["A39articulosmovdepositario","A40articulosmovfechamov","A41articulosmovstatus","A42articulosmovagregomovsist","A43articulosmovususuario","A44articulosmovfecreg","A45articulosmovfecultact","Gx_mode","Z3articulosmovid","Z4articulosmovproductoid","Z5articulosmovcambsid","Z6articulosmovarticuloid","Z39articulosmovdepositario","Z40articulosmovfechamov","Z41articulosmovstatus","Z42articulosmovagregomovsist","Z43articulosmovususuario","Z44articulosmovfecreg","Z45articulosmovfecultact",["BTN_DELETE","Enabled"],["BTN_ENTER","Enabled"]]),!0};this.e110d13_client=function(){this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e120d13_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,16,17,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65];this.GXLastCtrlId=65;n[2]={fld:"",grid:0};n[3]={fld:"TABLEMAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"TITLE",format:0,grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"",grid:0};n[10]={fld:"",grid:0};n[16]={fld:"",grid:0};n[17]={fld:"",grid:0};n[19]={fld:"",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Articulosmovid,isvalid:null,rgrid:[],fld:"ARTICULOSMOVID",gxz:"Z3articulosmovid",gxold:"O3articulosmovid",gxvar:"A3articulosmovid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A3articulosmovid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z3articulosmovid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ARTICULOSMOVID",gx.O.A3articulosmovid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A3articulosmovid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ARTICULOSMOVID",".")},nac:gx.falseFn};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Articulosmovproductoid,isvalid:null,rgrid:[],fld:"ARTICULOSMOVPRODUCTOID",gxz:"Z4articulosmovproductoid",gxold:"O4articulosmovproductoid",gxvar:"A4articulosmovproductoid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A4articulosmovproductoid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z4articulosmovproductoid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ARTICULOSMOVPRODUCTOID",gx.O.A4articulosmovproductoid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A4articulosmovproductoid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ARTICULOSMOVPRODUCTOID",".")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"",grid:0};n[30]={lvl:0,type:"svchar",len:3,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Articulosmovcambsid,isvalid:null,rgrid:[],fld:"ARTICULOSMOVCAMBSID",gxz:"Z5articulosmovcambsid",gxold:"O5articulosmovcambsid",gxvar:"A5articulosmovcambsid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A5articulosmovcambsid=n)},v2z:function(n){n!==undefined&&(gx.O.Z5articulosmovcambsid=n)},v2c:function(){gx.fn.setControlValue("ARTICULOSMOVCAMBSID",gx.O.A5articulosmovcambsid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A5articulosmovcambsid=this.val())},val:function(){return gx.fn.getControlValue("ARTICULOSMOVCAMBSID")},nac:gx.falseFn};n[31]={fld:"",grid:0};n[32]={fld:"",grid:0};n[33]={fld:"",grid:0};n[34]={lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Articulosmovarticuloid,isvalid:null,rgrid:[],fld:"ARTICULOSMOVARTICULOID",gxz:"Z6articulosmovarticuloid",gxold:"O6articulosmovarticuloid",gxvar:"A6articulosmovarticuloid",ucs:[],op:[62,58,54,50,46,42,38],ip:[62,58,54,50,46,42,38,34,30,26,22],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A6articulosmovarticuloid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z6articulosmovarticuloid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ARTICULOSMOVARTICULOID",gx.O.A6articulosmovarticuloid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A6articulosmovarticuloid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ARTICULOSMOVARTICULOID",".")},nac:gx.falseFn};n[35]={fld:"",grid:0};n[36]={fld:"",grid:0};n[37]={fld:"",grid:0};n[38]={lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOSMOVDEPOSITARIO",gxz:"Z39articulosmovdepositario",gxold:"O39articulosmovdepositario",gxvar:"A39articulosmovdepositario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A39articulosmovdepositario=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z39articulosmovdepositario=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ARTICULOSMOVDEPOSITARIO",gx.O.A39articulosmovdepositario,0)},c2v:function(){this.val()!==undefined&&(gx.O.A39articulosmovdepositario=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ARTICULOSMOVDEPOSITARIO",".")},nac:gx.falseFn};n[39]={fld:"",grid:0};n[40]={fld:"",grid:0};n[41]={fld:"",grid:0};n[42]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOSMOVFECHAMOV",gxz:"Z40articulosmovfechamov",gxold:"O40articulosmovfechamov",gxvar:"A40articulosmovfechamov",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A40articulosmovfechamov=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z40articulosmovfechamov=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("ARTICULOSMOVFECHAMOV",gx.O.A40articulosmovfechamov,0)},c2v:function(){this.val()!==undefined&&(gx.O.A40articulosmovfechamov=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("ARTICULOSMOVFECHAMOV")},nac:gx.falseFn};n[43]={fld:"",grid:0};n[44]={fld:"",grid:0};n[45]={fld:"",grid:0};n[46]={lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOSMOVSTATUS",gxz:"Z41articulosmovstatus",gxold:"O41articulosmovstatus",gxvar:"A41articulosmovstatus",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A41articulosmovstatus=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z41articulosmovstatus=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ARTICULOSMOVSTATUS",gx.O.A41articulosmovstatus,0)},c2v:function(){this.val()!==undefined&&(gx.O.A41articulosmovstatus=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ARTICULOSMOVSTATUS",".")},nac:gx.falseFn};n[47]={fld:"",grid:0};n[48]={fld:"",grid:0};n[49]={fld:"",grid:0};n[50]={lvl:0,type:"svchar",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOSMOVAGREGOMOVSIST",gxz:"Z42articulosmovagregomovsist",gxold:"O42articulosmovagregomovsist",gxvar:"A42articulosmovagregomovsist",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A42articulosmovagregomovsist=n)},v2z:function(n){n!==undefined&&(gx.O.Z42articulosmovagregomovsist=n)},v2c:function(){gx.fn.setControlValue("ARTICULOSMOVAGREGOMOVSIST",gx.O.A42articulosmovagregomovsist,0)},c2v:function(){this.val()!==undefined&&(gx.O.A42articulosmovagregomovsist=this.val())},val:function(){return gx.fn.getControlValue("ARTICULOSMOVAGREGOMOVSIST")},nac:gx.falseFn};n[51]={fld:"",grid:0};n[52]={fld:"",grid:0};n[53]={fld:"",grid:0};n[54]={lvl:0,type:"svchar",len:15,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOSMOVUSUSUARIO",gxz:"Z43articulosmovususuario",gxold:"O43articulosmovususuario",gxvar:"A43articulosmovususuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A43articulosmovususuario=n)},v2z:function(n){n!==undefined&&(gx.O.Z43articulosmovususuario=n)},v2c:function(){gx.fn.setControlValue("ARTICULOSMOVUSUSUARIO",gx.O.A43articulosmovususuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.A43articulosmovususuario=this.val())},val:function(){return gx.fn.getControlValue("ARTICULOSMOVUSUSUARIO")},nac:gx.falseFn};n[55]={fld:"",grid:0};n[56]={fld:"",grid:0};n[57]={fld:"",grid:0};n[58]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOSMOVFECREG",gxz:"Z44articulosmovfecreg",gxold:"O44articulosmovfecreg",gxvar:"A44articulosmovfecreg",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A44articulosmovfecreg=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z44articulosmovfecreg=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("ARTICULOSMOVFECREG",gx.O.A44articulosmovfecreg,0)},c2v:function(){this.val()!==undefined&&(gx.O.A44articulosmovfecreg=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("ARTICULOSMOVFECREG")},nac:gx.falseFn};n[59]={fld:"",grid:0};n[60]={fld:"",grid:0};n[61]={fld:"",grid:0};n[62]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOSMOVFECULTACT",gxz:"Z45articulosmovfecultact",gxold:"O45articulosmovfecultact",gxvar:"A45articulosmovfecultact",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A45articulosmovfecultact=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z45articulosmovfecultact=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("ARTICULOSMOVFECULTACT",gx.O.A45articulosmovfecultact,0)},c2v:function(){this.val()!==undefined&&(gx.O.A45articulosmovfecultact=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("ARTICULOSMOVFECULTACT")},nac:gx.falseFn};n[63]={fld:"",grid:0};n[64]={fld:"",grid:0};n[65]={fld:"",grid:0};this.A3articulosmovid=0;this.Z3articulosmovid=0;this.O3articulosmovid=0;this.A4articulosmovproductoid=0;this.Z4articulosmovproductoid=0;this.O4articulosmovproductoid=0;this.A5articulosmovcambsid="";this.Z5articulosmovcambsid="";this.O5articulosmovcambsid="";this.A6articulosmovarticuloid=0;this.Z6articulosmovarticuloid=0;this.O6articulosmovarticuloid=0;this.A39articulosmovdepositario=0;this.Z39articulosmovdepositario=0;this.O39articulosmovdepositario=0;this.A40articulosmovfechamov=gx.date.nullDate();this.Z40articulosmovfechamov=gx.date.nullDate();this.O40articulosmovfechamov=gx.date.nullDate();this.A41articulosmovstatus=0;this.Z41articulosmovstatus=0;this.O41articulosmovstatus=0;this.A42articulosmovagregomovsist="";this.Z42articulosmovagregomovsist="";this.O42articulosmovagregomovsist="";this.A43articulosmovususuario="";this.Z43articulosmovususuario="";this.O43articulosmovususuario="";this.A44articulosmovfecreg=gx.date.nullDate();this.Z44articulosmovfecreg=gx.date.nullDate();this.O44articulosmovfecreg=gx.date.nullDate();this.A45articulosmovfecultact=gx.date.nullDate();this.Z45articulosmovfecultact=gx.date.nullDate();this.O45articulosmovfecultact=gx.date.nullDate();this.A3articulosmovid=0;this.A4articulosmovproductoid=0;this.A5articulosmovcambsid="";this.A6articulosmovarticuloid=0;this.A39articulosmovdepositario=0;this.A40articulosmovfechamov=gx.date.nullDate();this.A41articulosmovstatus=0;this.A42articulosmovagregomovsist="";this.A43articulosmovususuario="";this.A44articulosmovfecreg=gx.date.nullDate();this.A45articulosmovfecultact=gx.date.nullDate();this.Events={e110d13_client:["ENTER",!0],e120d13_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0}],[]];this.EvtParms.REFRESH=[[],[]];this.EnterCtrl=["BTN_ENTER"];this.setVCMap("Gx_mode","vMODE",0,"char");this.InitStandaloneVars()});gx.createParentObj(articulosmov)