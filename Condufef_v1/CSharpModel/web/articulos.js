/**@preserve  GeneXus C# 10_3_15-115824 on 2/10/2022 20:2:8.0
*/
gx.evt.autoSkip=!1;gx.define("articulos",!1,function(){this.ServerClass="articulos";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Almacenid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Almacenid",["gx.O.A19almacenid"],[]),!0};this.Valid_Articulosproductoid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Articulosproductoid",["gx.O.A20articulosproductoid"],[]),!0};this.Valid_Articuloscambsid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Articuloscambsid",["gx.O.A19almacenid","gx.O.A20articulosproductoid","gx.O.A21articuloscambsid","gx.num.urlDecimal(gx.O.A154alamcenid,'.',',')","gx.num.urlDecimal(gx.O.A155articulosnoetiqueta,'.',',')","gx.O.A156articulosdsc","gx.num.urlDecimal(gx.O.A157articulospreciocompra,'.',',')","gx.num.urlDecimal(gx.O.A158articulospreccomprareexp,'.',',')","gx.num.urlDecimal(gx.O.A159articuloscantdepreacum,'.',',')","gx.O.A160articulosnumserie","gx.O.A161articulosrefdocumento",'gx.date.urlDateTime(gx.O.A162articulosfechacoteja,"DMY")','gx.date.urlDateTime(gx.O.A163articulosfechaentraalmacen,"DMY")','gx.date.urlDateTime(gx.O.A164articulosfechabajaalma,"DMY")',"gx.num.urlDecimal(gx.O.A165articulosstatus,'.',',')","gx.num.urlDecimal(gx.O.A166articuloscontejado,'.',',')","gx.O.A167articulosusuario","gx.O.A168articulosidtrasfer","gx.num.urlDecimal(gx.O.A169articulosestatusariticulo,'.',',')","gx.num.urlDecimal(gx.O.A170articulostipobien,'.',',')",'gx.date.urlDateTime(gx.O.A171articulosfecreg,"DMY")','gx.date.urlDateTime(gx.O.A172articulosfecultact,"DMY")',"gx.O.A23tipobienid","gx.O.A7entidafederativaid","gx.num.urlDecimal(gx.O.A10origenid,'.',',')","gx.O.A2proveedoresid"],["A154alamcenid","A155articulosnoetiqueta","A23tipobienid","A7entidafederativaid","A10origenid","A156articulosdsc","A2proveedoresid","A157articulospreciocompra","A158articulospreccomprareexp","A159articuloscantdepreacum","A160articulosnumserie","A161articulosrefdocumento","A162articulosfechacoteja","A163articulosfechaentraalmacen","A164articulosfechabajaalma","A165articulosstatus","A166articuloscontejado","A167articulosusuario","A168articulosidtrasfer","A169articulosestatusariticulo","A170articulostipobien","A171articulosfecreg","A172articulosfecultact","Gx_mode","Z19almacenid","Z20articulosproductoid","Z21articuloscambsid","Z154alamcenid","Z155articulosnoetiqueta","Z23tipobienid","Z7entidafederativaid","Z10origenid","Z156articulosdsc","Z2proveedoresid","Z157articulospreciocompra","Z158articulospreccomprareexp","Z159articuloscantdepreacum","Z160articulosnumserie","Z161articulosrefdocumento","Z162articulosfechacoteja","Z163articulosfechaentraalmacen","Z164articulosfechabajaalma","Z165articulosstatus","Z166articuloscontejado","Z167articulosusuario","Z168articulosidtrasfer","Z169articulosestatusariticulo","Z170articulostipobien","Z171articulosfecreg","Z172articulosfecultact",["BTN_DELETE","Enabled"],["BTN_ENTER","Enabled"]]),!0};this.Valid_Tipobienid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Tipobienid",["gx.O.A23tipobienid"],[]),!0};this.Valid_Entidafederativaid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Entidafederativaid",["gx.O.A7entidafederativaid"],[]),!0};this.Valid_Origenid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Origenid",["gx.num.urlDecimal(gx.O.A10origenid,'.',',')"],[]),!0};this.Valid_Proveedoresid=function(){return gx.ajax.validSrvEvt("dyncall","Valid_Proveedoresid",["gx.O.A2proveedoresid"],[]),!0};this.e110b11_client=function(){this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e120b11_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,16,17,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,100,101,102,103,104,105,106,107,108,109,110,111,112,113,114,115,116,117,118,119,120,121,122,123,124,125,129,130,131,132,133,134,135];this.GXLastCtrlId=135;n[2]={fld:"",grid:0};n[3]={fld:"TABLEMAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"TITLE",format:0,grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"",grid:0};n[10]={fld:"",grid:0};n[16]={fld:"",grid:0};n[17]={fld:"",grid:0};n[19]={fld:"",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Almacenid,isvalid:null,rgrid:[],fld:"ALMACENID",gxz:"Z19almacenid",gxold:"O19almacenid",gxvar:"A19almacenid",ucs:[],op:[],ip:[22],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A19almacenid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z19almacenid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ALMACENID",gx.O.A19almacenid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A19almacenid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ALMACENID",".")},nac:gx.falseFn};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Articulosproductoid,isvalid:null,rgrid:[],fld:"ARTICULOSPRODUCTOID",gxz:"Z20articulosproductoid",gxold:"O20articulosproductoid",gxvar:"A20articulosproductoid",ucs:[],op:[],ip:[26],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A20articulosproductoid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z20articulosproductoid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ARTICULOSPRODUCTOID",gx.O.A20articulosproductoid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A20articulosproductoid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ARTICULOSPRODUCTOID",".")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"",grid:0};n[30]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Articuloscambsid,isvalid:null,rgrid:[],fld:"ARTICULOSCAMBSID",gxz:"Z21articuloscambsid",gxold:"O21articuloscambsid",gxvar:"A21articuloscambsid",ucs:[],op:[58,50,46,42,122,118,114,110,106,102,98,94,90,86,82,78,74,70,66,62,54,38,34],ip:[58,50,46,42,122,118,114,110,106,102,98,94,90,86,82,78,74,70,66,62,54,38,34,30,26,22],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A21articuloscambsid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z21articuloscambsid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ARTICULOSCAMBSID",gx.O.A21articuloscambsid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A21articuloscambsid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ARTICULOSCAMBSID",".")},nac:gx.falseFn};n[31]={fld:"",grid:0};n[32]={fld:"",grid:0};n[33]={fld:"",grid:0};n[34]={lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ALAMCENID",gxz:"Z154alamcenid",gxold:"O154alamcenid",gxvar:"A154alamcenid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A154alamcenid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z154alamcenid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ALAMCENID",gx.O.A154alamcenid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A154alamcenid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ALAMCENID",".")},nac:gx.falseFn};n[35]={fld:"",grid:0};n[36]={fld:"",grid:0};n[37]={fld:"",grid:0};n[38]={lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOSNOETIQUETA",gxz:"Z155articulosnoetiqueta",gxold:"O155articulosnoetiqueta",gxvar:"A155articulosnoetiqueta",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A155articulosnoetiqueta=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z155articulosnoetiqueta=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ARTICULOSNOETIQUETA",gx.O.A155articulosnoetiqueta,0)},c2v:function(){this.val()!==undefined&&(gx.O.A155articulosnoetiqueta=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ARTICULOSNOETIQUETA",".")},nac:gx.falseFn};n[39]={fld:"",grid:0};n[40]={fld:"",grid:0};n[41]={fld:"",grid:0};n[42]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Tipobienid,isvalid:null,rgrid:[],fld:"TIPOBIENID",gxz:"Z23tipobienid",gxold:"O23tipobienid",gxvar:"A23tipobienid",ucs:[],op:[],ip:[42],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A23tipobienid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z23tipobienid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("TIPOBIENID",gx.O.A23tipobienid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A23tipobienid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("TIPOBIENID",".")},nac:gx.falseFn};n[43]={fld:"",grid:0};n[44]={fld:"",grid:0};n[45]={fld:"",grid:0};n[46]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Entidafederativaid,isvalid:null,rgrid:[],fld:"ENTIDAFEDERATIVAID",gxz:"Z7entidafederativaid",gxold:"O7entidafederativaid",gxvar:"A7entidafederativaid",ucs:[],op:[],ip:[46],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A7entidafederativaid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z7entidafederativaid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ENTIDAFEDERATIVAID",gx.O.A7entidafederativaid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A7entidafederativaid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ENTIDAFEDERATIVAID",".")},nac:gx.falseFn};n[47]={fld:"",grid:0};n[48]={fld:"",grid:0};n[49]={fld:"",grid:0};n[50]={lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Origenid,isvalid:null,rgrid:[],fld:"ORIGENID",gxz:"Z10origenid",gxold:"O10origenid",gxvar:"A10origenid",ucs:[],op:[],ip:[50],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A10origenid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z10origenid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ORIGENID",gx.O.A10origenid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A10origenid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ORIGENID",".")},nac:gx.falseFn};n[51]={fld:"",grid:0};n[52]={fld:"",grid:0};n[53]={fld:"",grid:0};n[54]={lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOSDSC",gxz:"Z156articulosdsc",gxold:"O156articulosdsc",gxvar:"A156articulosdsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A156articulosdsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z156articulosdsc=n)},v2c:function(){gx.fn.setControlValue("ARTICULOSDSC",gx.O.A156articulosdsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A156articulosdsc=this.val())},val:function(){return gx.fn.getControlValue("ARTICULOSDSC")},nac:gx.falseFn};n[55]={fld:"",grid:0};n[56]={fld:"",grid:0};n[57]={fld:"",grid:0};n[58]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Proveedoresid,isvalid:null,rgrid:[],fld:"PROVEEDORESID",gxz:"Z2proveedoresid",gxold:"O2proveedoresid",gxvar:"A2proveedoresid",ucs:[],op:[],ip:[58],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A2proveedoresid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z2proveedoresid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("PROVEEDORESID",gx.O.A2proveedoresid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A2proveedoresid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("PROVEEDORESID",".")},nac:gx.falseFn};n[59]={fld:"",grid:0};n[60]={fld:"",grid:0};n[61]={fld:"",grid:0};n[62]={lvl:0,type:"decimal",len:17,dec:6,sign:!1,pic:"ZZZZZZZZZ9.999999",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOSPRECIOCOMPRA",gxz:"Z157articulospreciocompra",gxold:"O157articulospreciocompra",gxvar:"A157articulospreciocompra",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A157articulospreciocompra=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z157articulospreciocompra=gx.fn.toDecimalValue(n,".",","))},v2c:function(){gx.fn.setDecimalValue("ARTICULOSPRECIOCOMPRA",gx.O.A157articulospreciocompra,6,",")},c2v:function(){this.val()!==undefined&&(gx.O.A157articulospreciocompra=this.val())},val:function(){return gx.fn.getDecimalValue("ARTICULOSPRECIOCOMPRA",".",",")},nac:gx.falseFn};n[63]={fld:"",grid:0};n[64]={fld:"",grid:0};n[65]={fld:"",grid:0};n[66]={lvl:0,type:"decimal",len:17,dec:6,sign:!1,pic:"ZZZZZZZZZ9.999999",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOSPRECCOMPRAREEXP",gxz:"Z158articulospreccomprareexp",gxold:"O158articulospreccomprareexp",gxvar:"A158articulospreccomprareexp",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A158articulospreccomprareexp=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z158articulospreccomprareexp=gx.fn.toDecimalValue(n,".",","))},v2c:function(){gx.fn.setDecimalValue("ARTICULOSPRECCOMPRAREEXP",gx.O.A158articulospreccomprareexp,6,",")},c2v:function(){this.val()!==undefined&&(gx.O.A158articulospreccomprareexp=this.val())},val:function(){return gx.fn.getDecimalValue("ARTICULOSPRECCOMPRAREEXP",".",",")},nac:gx.falseFn};n[67]={fld:"",grid:0};n[68]={fld:"",grid:0};n[69]={fld:"",grid:0};n[70]={lvl:0,type:"decimal",len:17,dec:6,sign:!1,pic:"ZZZZZZZZZ9.999999",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOSCANTDEPREACUM",gxz:"Z159articuloscantdepreacum",gxold:"O159articuloscantdepreacum",gxvar:"A159articuloscantdepreacum",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A159articuloscantdepreacum=gx.fn.toDecimalValue(n,",","."))},v2z:function(n){n!==undefined&&(gx.O.Z159articuloscantdepreacum=gx.fn.toDecimalValue(n,".",","))},v2c:function(){gx.fn.setDecimalValue("ARTICULOSCANTDEPREACUM",gx.O.A159articuloscantdepreacum,6,",")},c2v:function(){this.val()!==undefined&&(gx.O.A159articuloscantdepreacum=this.val())},val:function(){return gx.fn.getDecimalValue("ARTICULOSCANTDEPREACUM",".",",")},nac:gx.falseFn};n[71]={fld:"",grid:0};n[72]={fld:"",grid:0};n[73]={fld:"",grid:0};n[74]={lvl:0,type:"svchar",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOSNUMSERIE",gxz:"Z160articulosnumserie",gxold:"O160articulosnumserie",gxvar:"A160articulosnumserie",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A160articulosnumserie=n)},v2z:function(n){n!==undefined&&(gx.O.Z160articulosnumserie=n)},v2c:function(){gx.fn.setControlValue("ARTICULOSNUMSERIE",gx.O.A160articulosnumserie,0)},c2v:function(){this.val()!==undefined&&(gx.O.A160articulosnumserie=this.val())},val:function(){return gx.fn.getControlValue("ARTICULOSNUMSERIE")},nac:gx.falseFn};n[75]={fld:"",grid:0};n[76]={fld:"",grid:0};n[77]={fld:"",grid:0};n[78]={lvl:0,type:"svchar",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOSREFDOCUMENTO",gxz:"Z161articulosrefdocumento",gxold:"O161articulosrefdocumento",gxvar:"A161articulosrefdocumento",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A161articulosrefdocumento=n)},v2z:function(n){n!==undefined&&(gx.O.Z161articulosrefdocumento=n)},v2c:function(){gx.fn.setControlValue("ARTICULOSREFDOCUMENTO",gx.O.A161articulosrefdocumento,0)},c2v:function(){this.val()!==undefined&&(gx.O.A161articulosrefdocumento=this.val())},val:function(){return gx.fn.getControlValue("ARTICULOSREFDOCUMENTO")},nac:gx.falseFn};n[79]={fld:"",grid:0};n[80]={fld:"",grid:0};n[81]={fld:"",grid:0};n[82]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOSFECHACOTEJA",gxz:"Z162articulosfechacoteja",gxold:"O162articulosfechacoteja",gxvar:"A162articulosfechacoteja",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A162articulosfechacoteja=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z162articulosfechacoteja=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("ARTICULOSFECHACOTEJA",gx.O.A162articulosfechacoteja,0)},c2v:function(){this.val()!==undefined&&(gx.O.A162articulosfechacoteja=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("ARTICULOSFECHACOTEJA")},nac:gx.falseFn};n[83]={fld:"",grid:0};n[84]={fld:"",grid:0};n[85]={fld:"",grid:0};n[86]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOSFECHAENTRAALMACEN",gxz:"Z163articulosfechaentraalmacen",gxold:"O163articulosfechaentraalmacen",gxvar:"A163articulosfechaentraalmacen",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A163articulosfechaentraalmacen=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z163articulosfechaentraalmacen=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("ARTICULOSFECHAENTRAALMACEN",gx.O.A163articulosfechaentraalmacen,0)},c2v:function(){this.val()!==undefined&&(gx.O.A163articulosfechaentraalmacen=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("ARTICULOSFECHAENTRAALMACEN")},nac:gx.falseFn};n[87]={fld:"",grid:0};n[88]={fld:"",grid:0};n[89]={fld:"",grid:0};n[90]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOSFECHABAJAALMA",gxz:"Z164articulosfechabajaalma",gxold:"O164articulosfechabajaalma",gxvar:"A164articulosfechabajaalma",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A164articulosfechabajaalma=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z164articulosfechabajaalma=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("ARTICULOSFECHABAJAALMA",gx.O.A164articulosfechabajaalma,0)},c2v:function(){this.val()!==undefined&&(gx.O.A164articulosfechabajaalma=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("ARTICULOSFECHABAJAALMA")},nac:gx.falseFn};n[91]={fld:"",grid:0};n[92]={fld:"",grid:0};n[93]={fld:"",grid:0};n[94]={lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOSSTATUS",gxz:"Z165articulosstatus",gxold:"O165articulosstatus",gxvar:"A165articulosstatus",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A165articulosstatus=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z165articulosstatus=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ARTICULOSSTATUS",gx.O.A165articulosstatus,0)},c2v:function(){this.val()!==undefined&&(gx.O.A165articulosstatus=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ARTICULOSSTATUS",".")},nac:gx.falseFn};n[95]={fld:"",grid:0};n[96]={fld:"",grid:0};n[97]={fld:"",grid:0};n[98]={lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOSCONTEJADO",gxz:"Z166articuloscontejado",gxold:"O166articuloscontejado",gxvar:"A166articuloscontejado",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A166articuloscontejado=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z166articuloscontejado=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ARTICULOSCONTEJADO",gx.O.A166articuloscontejado,0)},c2v:function(){this.val()!==undefined&&(gx.O.A166articuloscontejado=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ARTICULOSCONTEJADO",".")},nac:gx.falseFn};n[99]={fld:"",grid:0};n[100]={fld:"",grid:0};n[101]={fld:"",grid:0};n[102]={lvl:0,type:"svchar",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOSUSUARIO",gxz:"Z167articulosusuario",gxold:"O167articulosusuario",gxvar:"A167articulosusuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A167articulosusuario=n)},v2z:function(n){n!==undefined&&(gx.O.Z167articulosusuario=n)},v2c:function(){gx.fn.setControlValue("ARTICULOSUSUARIO",gx.O.A167articulosusuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.A167articulosusuario=this.val())},val:function(){return gx.fn.getControlValue("ARTICULOSUSUARIO")},nac:gx.falseFn};n[103]={fld:"",grid:0};n[104]={fld:"",grid:0};n[105]={fld:"",grid:0};n[106]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOSIDTRASFER",gxz:"Z168articulosidtrasfer",gxold:"O168articulosidtrasfer",gxvar:"A168articulosidtrasfer",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A168articulosidtrasfer=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z168articulosidtrasfer=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ARTICULOSIDTRASFER",gx.O.A168articulosidtrasfer,0)},c2v:function(){this.val()!==undefined&&(gx.O.A168articulosidtrasfer=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ARTICULOSIDTRASFER",".")},nac:gx.falseFn};n[107]={fld:"",grid:0};n[108]={fld:"",grid:0};n[109]={fld:"",grid:0};n[110]={lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOSESTATUSARITICULO",gxz:"Z169articulosestatusariticulo",gxold:"O169articulosestatusariticulo",gxvar:"A169articulosestatusariticulo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A169articulosestatusariticulo=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z169articulosestatusariticulo=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ARTICULOSESTATUSARITICULO",gx.O.A169articulosestatusariticulo,0)},c2v:function(){this.val()!==undefined&&(gx.O.A169articulosestatusariticulo=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ARTICULOSESTATUSARITICULO",".")},nac:gx.falseFn};n[111]={fld:"",grid:0};n[112]={fld:"",grid:0};n[113]={fld:"",grid:0};n[114]={lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOSTIPOBIEN",gxz:"Z170articulostipobien",gxold:"O170articulostipobien",gxvar:"A170articulostipobien",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A170articulostipobien=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z170articulostipobien=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("ARTICULOSTIPOBIEN",gx.O.A170articulostipobien,0)},c2v:function(){this.val()!==undefined&&(gx.O.A170articulostipobien=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("ARTICULOSTIPOBIEN",".")},nac:gx.falseFn};n[115]={fld:"",grid:0};n[116]={fld:"",grid:0};n[117]={fld:"",grid:0};n[118]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOSFECREG",gxz:"Z171articulosfecreg",gxold:"O171articulosfecreg",gxvar:"A171articulosfecreg",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A171articulosfecreg=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z171articulosfecreg=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("ARTICULOSFECREG",gx.O.A171articulosfecreg,0)},c2v:function(){this.val()!==undefined&&(gx.O.A171articulosfecreg=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("ARTICULOSFECREG")},nac:gx.falseFn};n[119]={fld:"",grid:0};n[120]={fld:"",grid:0};n[121]={fld:"",grid:0};n[122]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"ARTICULOSFECULTACT",gxz:"Z172articulosfecultact",gxold:"O172articulosfecultact",gxvar:"A172articulosfecultact",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A172articulosfecultact=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z172articulosfecultact=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("ARTICULOSFECULTACT",gx.O.A172articulosfecultact,0)},c2v:function(){this.val()!==undefined&&(gx.O.A172articulosfecultact=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("ARTICULOSFECULTACT")},nac:gx.falseFn};n[123]={fld:"",grid:0};n[124]={fld:"",grid:0};n[125]={fld:"",grid:0};n[129]={fld:"PROMPT_19",grid:11};n[130]={fld:"PROMPT_20",grid:11};n[131]={fld:"PROMPT_21",grid:11};n[132]={fld:"PROMPT_23",grid:11};n[133]={fld:"PROMPT_7",grid:11};n[134]={fld:"PROMPT_10",grid:11};n[135]={fld:"PROMPT_2",grid:11};this.A19almacenid=0;this.Z19almacenid=0;this.O19almacenid=0;this.A20articulosproductoid=0;this.Z20articulosproductoid=0;this.O20articulosproductoid=0;this.A21articuloscambsid=0;this.Z21articuloscambsid=0;this.O21articuloscambsid=0;this.A154alamcenid=0;this.Z154alamcenid=0;this.O154alamcenid=0;this.A155articulosnoetiqueta=0;this.Z155articulosnoetiqueta=0;this.O155articulosnoetiqueta=0;this.A23tipobienid=0;this.Z23tipobienid=0;this.O23tipobienid=0;this.A7entidafederativaid=0;this.Z7entidafederativaid=0;this.O7entidafederativaid=0;this.A10origenid=0;this.Z10origenid=0;this.O10origenid=0;this.A156articulosdsc="";this.Z156articulosdsc="";this.O156articulosdsc="";this.A2proveedoresid=0;this.Z2proveedoresid=0;this.O2proveedoresid=0;this.A157articulospreciocompra=0;this.Z157articulospreciocompra=0;this.O157articulospreciocompra=0;this.A158articulospreccomprareexp=0;this.Z158articulospreccomprareexp=0;this.O158articulospreccomprareexp=0;this.A159articuloscantdepreacum=0;this.Z159articuloscantdepreacum=0;this.O159articuloscantdepreacum=0;this.A160articulosnumserie="";this.Z160articulosnumserie="";this.O160articulosnumserie="";this.A161articulosrefdocumento="";this.Z161articulosrefdocumento="";this.O161articulosrefdocumento="";this.A162articulosfechacoteja=gx.date.nullDate();this.Z162articulosfechacoteja=gx.date.nullDate();this.O162articulosfechacoteja=gx.date.nullDate();this.A163articulosfechaentraalmacen=gx.date.nullDate();this.Z163articulosfechaentraalmacen=gx.date.nullDate();this.O163articulosfechaentraalmacen=gx.date.nullDate();this.A164articulosfechabajaalma=gx.date.nullDate();this.Z164articulosfechabajaalma=gx.date.nullDate();this.O164articulosfechabajaalma=gx.date.nullDate();this.A165articulosstatus=0;this.Z165articulosstatus=0;this.O165articulosstatus=0;this.A166articuloscontejado=0;this.Z166articuloscontejado=0;this.O166articuloscontejado=0;this.A167articulosusuario="";this.Z167articulosusuario="";this.O167articulosusuario="";this.A168articulosidtrasfer=0;this.Z168articulosidtrasfer=0;this.O168articulosidtrasfer=0;this.A169articulosestatusariticulo=0;this.Z169articulosestatusariticulo=0;this.O169articulosestatusariticulo=0;this.A170articulostipobien=0;this.Z170articulostipobien=0;this.O170articulostipobien=0;this.A171articulosfecreg=gx.date.nullDate();this.Z171articulosfecreg=gx.date.nullDate();this.O171articulosfecreg=gx.date.nullDate();this.A172articulosfecultact=gx.date.nullDate();this.Z172articulosfecultact=gx.date.nullDate();this.O172articulosfecultact=gx.date.nullDate();this.A19almacenid=0;this.A20articulosproductoid=0;this.A21articuloscambsid=0;this.A154alamcenid=0;this.A155articulosnoetiqueta=0;this.A23tipobienid=0;this.A7entidafederativaid=0;this.A10origenid=0;this.A156articulosdsc="";this.A2proveedoresid=0;this.A157articulospreciocompra=0;this.A158articulospreccomprareexp=0;this.A159articuloscantdepreacum=0;this.A160articulosnumserie="";this.A161articulosrefdocumento="";this.A162articulosfechacoteja=gx.date.nullDate();this.A163articulosfechaentraalmacen=gx.date.nullDate();this.A164articulosfechabajaalma=gx.date.nullDate();this.A165articulosstatus=0;this.A166articuloscontejado=0;this.A167articulosusuario="";this.A168articulosidtrasfer=0;this.A169articulosestatusariticulo=0;this.A170articulostipobien=0;this.A171articulosfecreg=gx.date.nullDate();this.A172articulosfecultact=gx.date.nullDate();this.Events={e110b11_client:["ENTER",!0],e120b11_client:["CANCEL",!0]};this.EvtParms.ENTER=[[{postForm:!0}],[]];this.EvtParms.REFRESH=[[],[]];this.setPrompt("PROMPT_19",[22]);this.setPrompt("PROMPT_20",[26]);this.setPrompt("PROMPT_21",[30]);this.setPrompt("PROMPT_23",[42]);this.setPrompt("PROMPT_7",[46]);this.setPrompt("PROMPT_10",[50]);this.setPrompt("PROMPT_2",[58]);this.EnterCtrl=["BTN_ENTER"];this.setVCMap("Gx_mode","vMODE",0,"char");this.InitStandaloneVars()});gx.createParentObj(articulos)