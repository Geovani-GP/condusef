/**@preserve  GeneXus C# 10_3_15-115824 on 1/23/2022 3:49:17.34
*/
gx.evt.autoSkip=!1;gx.define("almacen",!1,function(){this.ServerClass="almacen";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Almacenid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Almacenid",["gx.num.urlDecimal(gx.O.A19almacenid,'.',',')","gx.O.A143almacendsc","gx.O.A144almacendireccion","gx.O.A145almacencolonia","gx.O.A146almacenmunicipio","gx.O.A147alamcenestado","gx.O.A148alamcencodigopostal","gx.O.A149almacentelefono","gx.O.A150alamcenobservaciones","gx.O.A151alamcenusuario",'gx.date.urlDateTime(gx.O.A152almacenfecreg,"DMY")','gx.date.urlDateTime(gx.O.A153almacenfecultact,"DMY")',"gx.O.A13empleadosid"],["A13empleadosid","A143almacendsc","A144almacendireccion","A145almacencolonia","A146almacenmunicipio","A147alamcenestado","A148alamcencodigopostal","A149almacentelefono","A150alamcenobservaciones","A151alamcenusuario","A152almacenfecreg","A153almacenfecultact","Gx_mode","Z19almacenid","Z13empleadosid","Z143almacendsc","Z144almacendireccion","Z145almacencolonia","Z146almacenmunicipio","Z147alamcenestado","Z148alamcencodigopostal","Z149almacentelefono","Z150alamcenobservaciones","Z151alamcenusuario","Z152almacenfecreg","Z153almacenfecultact",["BTN_DELETE","Enabled"],["BTN_ENTER","Enabled"]]),!0};this.Valid_Empleadosid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Empleadosid",["gx.O.A13empleadosid"],[]),!0};this.e110i18_client=function(){this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e120i18_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,16,17,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,77];this.GXLastCtrlId=77;n[2]={fld:"",grid:0};n[3]={fld:"TABLEMAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"TITLE",format:0,grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"",grid:0};n[10]={fld:"",grid:0};n[16]={fld:"",grid:0};n[17]={fld:"",grid:0};n[19]={fld:"",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Almacenid,isvalid:null,rgrid:[],fld:"ALMACENID",gxz:"Z19almacenid",gxold:"O19almacenid",gxvar:"A19almacenid",ucs:[],op:[26,70,66,62,58,54,50,46,42,38,34,30],ip:[26,70,66,62,58,54,50,46,42,38,34,30,22],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A19almacenid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z19almacenid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ALMACENID",gx.O.A19almacenid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A19almacenid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ALMACENID",".")},nac:gx.falseFn};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Empleadosid,isvalid:null,rgrid:[],fld:"EMPLEADOSID",gxz:"Z13empleadosid",gxold:"O13empleadosid",gxvar:"A13empleadosid",ucs:[],op:[],ip:[26],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A13empleadosid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z13empleadosid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("EMPLEADOSID",gx.O.A13empleadosid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A13empleadosid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("EMPLEADOSID",".")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"",grid:0};n[30]={lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ALMACENDSC",gxz:"Z143almacendsc",gxold:"O143almacendsc",gxvar:"A143almacendsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A143almacendsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z143almacendsc=n)},v2c:function(){gx.fn.setControlValue("ALMACENDSC",gx.O.A143almacendsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A143almacendsc=this.val())},val:function(){return gx.fn.getControlValue("ALMACENDSC")},nac:gx.falseFn};n[31]={fld:"",grid:0};n[32]={fld:"",grid:0};n[33]={fld:"",grid:0};n[34]={lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ALMACENDIRECCION",gxz:"Z144almacendireccion",gxold:"O144almacendireccion",gxvar:"A144almacendireccion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A144almacendireccion=n)},v2z:function(n){n!==undefined&&(gx.O.Z144almacendireccion=n)},v2c:function(){gx.fn.setControlValue("ALMACENDIRECCION",gx.O.A144almacendireccion,0)},c2v:function(){this.val()!==undefined&&(gx.O.A144almacendireccion=this.val())},val:function(){return gx.fn.getControlValue("ALMACENDIRECCION")},nac:gx.falseFn};n[35]={fld:"",grid:0};n[36]={fld:"",grid:0};n[37]={fld:"",grid:0};n[38]={lvl:0,type:"svchar",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ALMACENCOLONIA",gxz:"Z145almacencolonia",gxold:"O145almacencolonia",gxvar:"A145almacencolonia",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A145almacencolonia=n)},v2z:function(n){n!==undefined&&(gx.O.Z145almacencolonia=n)},v2c:function(){gx.fn.setControlValue("ALMACENCOLONIA",gx.O.A145almacencolonia,0)},c2v:function(){this.val()!==undefined&&(gx.O.A145almacencolonia=this.val())},val:function(){return gx.fn.getControlValue("ALMACENCOLONIA")},nac:gx.falseFn};n[39]={fld:"",grid:0};n[40]={fld:"",grid:0};n[41]={fld:"",grid:0};n[42]={lvl:0,type:"svchar",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ALMACENMUNICIPIO",gxz:"Z146almacenmunicipio",gxold:"O146almacenmunicipio",gxvar:"A146almacenmunicipio",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A146almacenmunicipio=n)},v2z:function(n){n!==undefined&&(gx.O.Z146almacenmunicipio=n)},v2c:function(){gx.fn.setControlValue("ALMACENMUNICIPIO",gx.O.A146almacenmunicipio,0)},c2v:function(){this.val()!==undefined&&(gx.O.A146almacenmunicipio=this.val())},val:function(){return gx.fn.getControlValue("ALMACENMUNICIPIO")},nac:gx.falseFn};n[43]={fld:"",grid:0};n[44]={fld:"",grid:0};n[45]={fld:"",grid:0};n[46]={lvl:0,type:"svchar",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ALAMCENESTADO",gxz:"Z147alamcenestado",gxold:"O147alamcenestado",gxvar:"A147alamcenestado",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A147alamcenestado=n)},v2z:function(n){n!==undefined&&(gx.O.Z147alamcenestado=n)},v2c:function(){gx.fn.setControlValue("ALAMCENESTADO",gx.O.A147alamcenestado,0)},c2v:function(){this.val()!==undefined&&(gx.O.A147alamcenestado=this.val())},val:function(){return gx.fn.getControlValue("ALAMCENESTADO")},nac:gx.falseFn};n[47]={fld:"",grid:0};n[48]={fld:"",grid:0};n[49]={fld:"",grid:0};n[50]={lvl:0,type:"svchar",len:5,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ALAMCENCODIGOPOSTAL",gxz:"Z148alamcencodigopostal",gxold:"O148alamcencodigopostal",gxvar:"A148alamcencodigopostal",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A148alamcencodigopostal=n)},v2z:function(n){n!==undefined&&(gx.O.Z148alamcencodigopostal=n)},v2c:function(){gx.fn.setControlValue("ALAMCENCODIGOPOSTAL",gx.O.A148alamcencodigopostal,0)},c2v:function(){this.val()!==undefined&&(gx.O.A148alamcencodigopostal=this.val())},val:function(){return gx.fn.getControlValue("ALAMCENCODIGOPOSTAL")},nac:gx.falseFn};n[51]={fld:"",grid:0};n[52]={fld:"",grid:0};n[53]={fld:"",grid:0};n[54]={lvl:0,type:"svchar",len:10,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ALMACENTELEFONO",gxz:"Z149almacentelefono",gxold:"O149almacentelefono",gxvar:"A149almacentelefono",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A149almacentelefono=n)},v2z:function(n){n!==undefined&&(gx.O.Z149almacentelefono=n)},v2c:function(){gx.fn.setControlValue("ALMACENTELEFONO",gx.O.A149almacentelefono,0)},c2v:function(){this.val()!==undefined&&(gx.O.A149almacentelefono=this.val())},val:function(){return gx.fn.getControlValue("ALMACENTELEFONO")},nac:gx.falseFn};n[55]={fld:"",grid:0};n[56]={fld:"",grid:0};n[57]={fld:"",grid:0};n[58]={lvl:0,type:"svchar",len:50,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ALAMCENOBSERVACIONES",gxz:"Z150alamcenobservaciones",gxold:"O150alamcenobservaciones",gxvar:"A150alamcenobservaciones",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A150alamcenobservaciones=n)},v2z:function(n){n!==undefined&&(gx.O.Z150alamcenobservaciones=n)},v2c:function(){gx.fn.setControlValue("ALAMCENOBSERVACIONES",gx.O.A150alamcenobservaciones,0)},c2v:function(){this.val()!==undefined&&(gx.O.A150alamcenobservaciones=this.val())},val:function(){return gx.fn.getControlValue("ALAMCENOBSERVACIONES")},nac:gx.falseFn};n[59]={fld:"",grid:0};n[60]={fld:"",grid:0};n[61]={fld:"",grid:0};n[62]={lvl:0,type:"svchar",len:15,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ALAMCENUSUARIO",gxz:"Z151alamcenusuario",gxold:"O151alamcenusuario",gxvar:"A151alamcenusuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A151alamcenusuario=n)},v2z:function(n){n!==undefined&&(gx.O.Z151alamcenusuario=n)},v2c:function(){gx.fn.setControlValue("ALAMCENUSUARIO",gx.O.A151alamcenusuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.A151alamcenusuario=this.val())},val:function(){return gx.fn.getControlValue("ALAMCENUSUARIO")},nac:gx.falseFn};n[63]={fld:"",grid:0};n[64]={fld:"",grid:0};n[65]={fld:"",grid:0};n[66]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ALMACENFECREG",gxz:"Z152almacenfecreg",gxold:"O152almacenfecreg",gxvar:"A152almacenfecreg",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A152almacenfecreg=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z152almacenfecreg=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("ALMACENFECREG",gx.O.A152almacenfecreg,0)},c2v:function(){this.val()!==undefined&&(gx.O.A152almacenfecreg=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("ALMACENFECREG")},nac:gx.falseFn};n[67]={fld:"",grid:0};n[68]={fld:"",grid:0};n[69]={fld:"",grid:0};n[70]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ALMACENFECULTACT",gxz:"Z153almacenfecultact",gxold:"O153almacenfecultact",gxvar:"A153almacenfecultact",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A153almacenfecultact=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z153almacenfecultact=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("ALMACENFECULTACT",gx.O.A153almacenfecultact,0)},c2v:function(){this.val()!==undefined&&(gx.O.A153almacenfecultact=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("ALMACENFECULTACT")},nac:gx.falseFn};n[71]={fld:"",grid:0};n[72]={fld:"",grid:0};n[73]={fld:"",grid:0};n[77]={fld:"PROMPT_13",grid:18};this.A19almacenid=0;this.Z19almacenid=0;this.O19almacenid=0;this.A13empleadosid=0;this.Z13empleadosid=0;this.O13empleadosid=0;this.A143almacendsc="";this.Z143almacendsc="";this.O143almacendsc="";this.A144almacendireccion="";this.Z144almacendireccion="";this.O144almacendireccion="";this.A145almacencolonia="";this.Z145almacencolonia="";this.O145almacencolonia="";this.A146almacenmunicipio="";this.Z146almacenmunicipio="";this.O146almacenmunicipio="";this.A147alamcenestado="";this.Z147alamcenestado="";this.O147alamcenestado="";this.A148alamcencodigopostal="";this.Z148alamcencodigopostal="";this.O148alamcencodigopostal="";this.A149almacentelefono="";this.Z149almacentelefono="";this.O149almacentelefono="";this.A150alamcenobservaciones="";this.Z150alamcenobservaciones="";this.O150alamcenobservaciones="";this.A151alamcenusuario="";this.Z151alamcenusuario="";this.O151alamcenusuario="";this.A152almacenfecreg=gx.date.nullDate();this.Z152almacenfecreg=gx.date.nullDate();this.O152almacenfecreg=gx.date.nullDate();this.A153almacenfecultact=gx.date.nullDate();this.Z153almacenfecultact=gx.date.nullDate();this.O153almacenfecultact=gx.date.nullDate();this.A19almacenid=0;this.A13empleadosid=0;this.A143almacendsc="";this.A144almacendireccion="";this.A145almacencolonia="";this.A146almacenmunicipio="";this.A147alamcenestado="";this.A148alamcencodigopostal="";this.A149almacentelefono="";this.A150alamcenobservaciones="";this.A151alamcenusuario="";this.A152almacenfecreg=gx.date.nullDate();this.A153almacenfecultact=gx.date.nullDate();this.Events={e110i18_client:["ENTER",!0],e120i18_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0}],[]];this.EvtParms.REFRESH=[[],[]];this.setPrompt("PROMPT_13",[26]);this.EnterCtrl=["BTN_ENTER"];this.setVCMap("Gx_mode","vMODE",0,"char");this.InitStandaloneVars()});gx.createParentObj(almacen)