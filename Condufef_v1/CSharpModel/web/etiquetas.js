/**@preserve  GeneXus C# 10_3_15-115824 on 1/26/2022 20:7:32.78
*/
gx.evt.autoSkip=!1;gx.define("etiquetas",!1,function(){this.ServerClass="etiquetas";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Etiquetasproductoid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Etiquetasproductoid",["gx.O.A17etiquetasproductoid"],[]),!0};this.Valid_Etiquetascambsid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Etiquetascambsid",["gx.O.A18etiquetascambsid"],[]),!0};this.Valid_Almacenid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Almacenid",["gx.O.A17etiquetasproductoid","gx.O.A18etiquetascambsid","gx.num.urlDecimal(gx.O.A19almacenid,'.',',')","gx.num.urlDecimal(gx.O.A32etiquetasnumero,'.',',')","gx.num.urlDecimal(gx.O.A33etiquetastatus,'.',',')",'gx.date.urlDateTime(gx.O.A34etiquetafecharealizada,"DMY")',"gx.num.urlDecimal(gx.O.A35etiquetasreimpresion,'.',',')","gx.O.A36etiquetasusuario",'gx.date.urlDateTime(gx.O.A37etiquetasfecreg,"DMY")','gx.date.urlDateTime(gx.O.A38etiquetasfecultact,"DMY")'],["A32etiquetasnumero","A33etiquetastatus","A34etiquetafecharealizada","A35etiquetasreimpresion","A36etiquetasusuario","A37etiquetasfecreg","A38etiquetasfecultact","Gx_mode","Z17etiquetasproductoid","Z18etiquetascambsid","Z19almacenid","Z32etiquetasnumero","Z33etiquetastatus","Z34etiquetafecharealizada","Z35etiquetasreimpresion","Z36etiquetasusuario","Z37etiquetasfecreg","Z38etiquetasfecultact",["BTN_DELETE","Enabled"],["BTN_ENTER","Enabled"]]),!0};this.e110c12_client=function(){this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e120c12_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,16,17,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,65,66,67];this.GXLastCtrlId=67;n[2]={fld:"",grid:0};n[3]={fld:"TABLEMAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"TITLE",format:0,grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"",grid:0};n[10]={fld:"",grid:0};n[16]={fld:"",grid:0};n[17]={fld:"",grid:0};n[19]={fld:"",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Etiquetasproductoid,isvalid:null,rgrid:[],fld:"ETIQUETASPRODUCTOID",gxz:"Z17etiquetasproductoid",gxold:"O17etiquetasproductoid",gxvar:"A17etiquetasproductoid",ucs:[],op:[],ip:[22],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A17etiquetasproductoid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z17etiquetasproductoid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ETIQUETASPRODUCTOID",gx.O.A17etiquetasproductoid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A17etiquetasproductoid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ETIQUETASPRODUCTOID",".")},nac:gx.falseFn};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Etiquetascambsid,isvalid:null,rgrid:[],fld:"ETIQUETASCAMBSID",gxz:"Z18etiquetascambsid",gxold:"O18etiquetascambsid",gxvar:"A18etiquetascambsid",ucs:[],op:[],ip:[26],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A18etiquetascambsid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z18etiquetascambsid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ETIQUETASCAMBSID",gx.O.A18etiquetascambsid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A18etiquetascambsid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ETIQUETASCAMBSID",".")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"",grid:0};n[30]={lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Almacenid,isvalid:null,rgrid:[],fld:"ALMACENID",gxz:"Z19almacenid",gxold:"O19almacenid",gxvar:"A19almacenid",ucs:[],op:[58,54,50,46,42,38,34],ip:[58,54,50,46,42,38,34,30,26,22],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A19almacenid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z19almacenid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ALMACENID",gx.O.A19almacenid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A19almacenid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ALMACENID",".")},nac:gx.falseFn};n[31]={fld:"",grid:0};n[32]={fld:"",grid:0};n[33]={fld:"",grid:0};n[34]={lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ETIQUETASNUMERO",gxz:"Z32etiquetasnumero",gxold:"O32etiquetasnumero",gxvar:"A32etiquetasnumero",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A32etiquetasnumero=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z32etiquetasnumero=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ETIQUETASNUMERO",gx.O.A32etiquetasnumero,0)},c2v:function(){this.val()!==undefined&&(gx.O.A32etiquetasnumero=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ETIQUETASNUMERO",".")},nac:gx.falseFn};n[35]={fld:"",grid:0};n[36]={fld:"",grid:0};n[37]={fld:"",grid:0};n[38]={lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ETIQUETASTATUS",gxz:"Z33etiquetastatus",gxold:"O33etiquetastatus",gxvar:"A33etiquetastatus",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A33etiquetastatus=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z33etiquetastatus=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ETIQUETASTATUS",gx.O.A33etiquetastatus,0)},c2v:function(){this.val()!==undefined&&(gx.O.A33etiquetastatus=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ETIQUETASTATUS",".")},nac:gx.falseFn};n[39]={fld:"",grid:0};n[40]={fld:"",grid:0};n[41]={fld:"",grid:0};n[42]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ETIQUETAFECHAREALIZADA",gxz:"Z34etiquetafecharealizada",gxold:"O34etiquetafecharealizada",gxvar:"A34etiquetafecharealizada",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A34etiquetafecharealizada=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z34etiquetafecharealizada=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("ETIQUETAFECHAREALIZADA",gx.O.A34etiquetafecharealizada,0)},c2v:function(){this.val()!==undefined&&(gx.O.A34etiquetafecharealizada=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("ETIQUETAFECHAREALIZADA")},nac:gx.falseFn};n[43]={fld:"",grid:0};n[44]={fld:"",grid:0};n[45]={fld:"",grid:0};n[46]={lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ETIQUETASREIMPRESION",gxz:"Z35etiquetasreimpresion",gxold:"O35etiquetasreimpresion",gxvar:"A35etiquetasreimpresion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A35etiquetasreimpresion=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z35etiquetasreimpresion=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ETIQUETASREIMPRESION",gx.O.A35etiquetasreimpresion,0)},c2v:function(){this.val()!==undefined&&(gx.O.A35etiquetasreimpresion=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ETIQUETASREIMPRESION",".")},nac:gx.falseFn};n[47]={fld:"",grid:0};n[48]={fld:"",grid:0};n[49]={fld:"",grid:0};n[50]={lvl:0,type:"svchar",len:15,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ETIQUETASUSUARIO",gxz:"Z36etiquetasusuario",gxold:"O36etiquetasusuario",gxvar:"A36etiquetasusuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A36etiquetasusuario=n)},v2z:function(n){n!==undefined&&(gx.O.Z36etiquetasusuario=n)},v2c:function(){gx.fn.setControlValue("ETIQUETASUSUARIO",gx.O.A36etiquetasusuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.A36etiquetasusuario=this.val())},val:function(){return gx.fn.getControlValue("ETIQUETASUSUARIO")},nac:gx.falseFn};n[51]={fld:"",grid:0};n[52]={fld:"",grid:0};n[53]={fld:"",grid:0};n[54]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ETIQUETASFECREG",gxz:"Z37etiquetasfecreg",gxold:"O37etiquetasfecreg",gxvar:"A37etiquetasfecreg",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A37etiquetasfecreg=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z37etiquetasfecreg=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("ETIQUETASFECREG",gx.O.A37etiquetasfecreg,0)},c2v:function(){this.val()!==undefined&&(gx.O.A37etiquetasfecreg=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("ETIQUETASFECREG")},nac:gx.falseFn};n[55]={fld:"",grid:0};n[56]={fld:"",grid:0};n[57]={fld:"",grid:0};n[58]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ETIQUETASFECULTACT",gxz:"Z38etiquetasfecultact",gxold:"O38etiquetasfecultact",gxvar:"A38etiquetasfecultact",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A38etiquetasfecultact=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z38etiquetasfecultact=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("ETIQUETASFECULTACT",gx.O.A38etiquetasfecultact,0)},c2v:function(){this.val()!==undefined&&(gx.O.A38etiquetasfecultact=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("ETIQUETASFECULTACT")},nac:gx.falseFn};n[59]={fld:"",grid:0};n[60]={fld:"",grid:0};n[61]={fld:"",grid:0};n[65]={fld:"PROMPT_17",grid:12};n[66]={fld:"PROMPT_18",grid:12};n[67]={fld:"PROMPT_19",grid:12};this.A17etiquetasproductoid=0;this.Z17etiquetasproductoid=0;this.O17etiquetasproductoid=0;this.A18etiquetascambsid=0;this.Z18etiquetascambsid=0;this.O18etiquetascambsid=0;this.A19almacenid=0;this.Z19almacenid=0;this.O19almacenid=0;this.A32etiquetasnumero=0;this.Z32etiquetasnumero=0;this.O32etiquetasnumero=0;this.A33etiquetastatus=0;this.Z33etiquetastatus=0;this.O33etiquetastatus=0;this.A34etiquetafecharealizada=gx.date.nullDate();this.Z34etiquetafecharealizada=gx.date.nullDate();this.O34etiquetafecharealizada=gx.date.nullDate();this.A35etiquetasreimpresion=0;this.Z35etiquetasreimpresion=0;this.O35etiquetasreimpresion=0;this.A36etiquetasusuario="";this.Z36etiquetasusuario="";this.O36etiquetasusuario="";this.A37etiquetasfecreg=gx.date.nullDate();this.Z37etiquetasfecreg=gx.date.nullDate();this.O37etiquetasfecreg=gx.date.nullDate();this.A38etiquetasfecultact=gx.date.nullDate();this.Z38etiquetasfecultact=gx.date.nullDate();this.O38etiquetasfecultact=gx.date.nullDate();this.A17etiquetasproductoid=0;this.A18etiquetascambsid=0;this.A19almacenid=0;this.A32etiquetasnumero=0;this.A33etiquetastatus=0;this.A34etiquetafecharealizada=gx.date.nullDate();this.A35etiquetasreimpresion=0;this.A36etiquetasusuario="";this.A37etiquetasfecreg=gx.date.nullDate();this.A38etiquetasfecultact=gx.date.nullDate();this.Events={e110c12_client:["ENTER",!0],e120c12_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0}],[]];this.EvtParms.REFRESH=[[],[]];this.setPrompt("PROMPT_17",[22]);this.setPrompt("PROMPT_18",[26]);this.setPrompt("PROMPT_19",[30]);this.EnterCtrl=["BTN_ENTER"];this.setVCMap("Gx_mode","vMODE",0,"char");this.InitStandaloneVars()});gx.createParentObj(etiquetas)