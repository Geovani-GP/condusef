/**@preserve  GeneXus C# 10_3_15-115824 on 3/31/2022 0:19:38.92
*/
gx.evt.autoSkip=!1;gx.define("detallesalmacen",!1,function(){var t,n;this.ServerClass="detallesalmacen";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.e13372_client=function(){this.executeServerEvent("VUPDATEIMAGE.CLICK",!0,arguments[0],!1,!1)};this.e14372_client=function(){this.executeServerEvent("VDELETEIMAGE.CLICK",!0,arguments[0],!1,!1)};this.e11372_client=function(){this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e16372_client=function(){this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];t=this.GXValidFnc;this.GXCtrlIds=[2,5,7,12,13,14,15,16,17,18,19,20];this.GXLastCtrlId=20;this.AlamacengridContainer=new gx.grid.grid(this,2,"WbpLvl2",11,"Alamacengrid","Alamacengrid","AlamacengridContainer",this.CmpContext,this.IsMasterPage,"detallesalmacen",[],!1,1,!1,!0,0,!1,!1,!1,"",0,"px","Nueva fila",!1,!1,!1,null,null,!1,"",!1,[1,1,1,1]);n=this.AlamacengridContainer;n.addSingleLineEdit(19,12,"ALMACENID","ID","","almacenid","int",0,"px",9,9,"right",null,[],19,"almacenid",!0,0,!1,!1,"Attribute",1,"");n.addSingleLineEdit(143,13,"ALMACENDSC","Descripcion","","almacendsc","svchar",0,"px",100,80,"left",null,[],143,"almacendsc",!0,0,!1,!1,"Attribute",1,"");n.addSingleLineEdit(144,14,"ALMACENDIRECCION","Direccion","","almacendireccion","svchar",0,"px",100,80,"left",null,[],144,"almacendireccion",!0,0,!1,!1,"Attribute",1,"");n.addSingleLineEdit(146,15,"ALMACENMUNICIPIO","Municipio","","almacenmunicipio","svchar",0,"px",50,50,"left",null,[],146,"almacenmunicipio",!0,0,!1,!1,"Attribute",1,"");n.addSingleLineEdit(147,16,"ALAMCENESTADO","Estado","","alamcenestado","svchar",0,"px",50,50,"left",null,[],147,"alamcenestado",!0,0,!1,!1,"Attribute",1,"");n.addSingleLineEdit(149,17,"ALMACENTELEFONO","Telefono","","almacentelefono","int",0,"px",10,10,"right",null,[],149,"almacentelefono",!0,0,!1,!1,"Attribute",1,"");n.addSingleLineEdit(148,18,"ALAMCENCODIGOPOSTAL","Codigo Postal","","alamcencodigopostal","svchar",0,"px",5,5,"left",null,[],148,"alamcencodigopostal",!0,0,!1,!1,"Attribute",1,"");n.addBitmap("&Updateimage","vUPDATEIMAGE",19,0,"px",17,"px","e13372_client","","","Image","");n.addBitmap("&Deleteimage","vDELETEIMAGE",20,0,"px",17,"px","e14372_client","","","Image","");this.setGrid(n);t[2]={fld:"TABLE1",grid:0};t[5]={lvl:0,type:"char",len:20,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.AlamacengridContainer],fld:"vBUSCAR",gxz:"ZV5buscar",gxold:"OV5buscar",gxvar:"AV5buscar",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV5buscar=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5buscar=n)},v2c:function(){gx.fn.setControlValue("vBUSCAR",gx.O.AV5buscar,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV5buscar=this.val())},val:function(){return gx.fn.getControlValue("vBUSCAR")},nac:gx.falseFn};t[7]={fld:"TEXTBLOCK1",format:0,grid:0};t[12]={lvl:2,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,isacc:0,grid:11,gxgrid:this.AlamacengridContainer,fnc:null,isvalid:null,rgrid:[],fld:"ALMACENID",gxz:"Z19almacenid",gxold:"O19almacenid",gxvar:"A19almacenid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A19almacenid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z19almacenid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ALMACENID",n||gx.fn.currentGridRowImpl(11),gx.O.A19almacenid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A19almacenid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("ALMACENID",n||gx.fn.currentGridRowImpl(11),".")},nac:gx.falseFn};t[13]={lvl:2,type:"svchar",len:100,dec:0,sign:!1,ro:1,isacc:0,grid:11,gxgrid:this.AlamacengridContainer,fnc:null,isvalid:null,rgrid:[],fld:"ALMACENDSC",gxz:"Z143almacendsc",gxold:"O143almacendsc",gxvar:"A143almacendsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A143almacendsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z143almacendsc=n)},v2c:function(n){gx.fn.setGridControlValue("ALMACENDSC",n||gx.fn.currentGridRowImpl(11),gx.O.A143almacendsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A143almacendsc=this.val())},val:function(n){return gx.fn.getGridControlValue("ALMACENDSC",n||gx.fn.currentGridRowImpl(11))},nac:gx.falseFn};t[14]={lvl:2,type:"svchar",len:100,dec:0,sign:!1,ro:1,isacc:0,grid:11,gxgrid:this.AlamacengridContainer,fnc:null,isvalid:null,rgrid:[],fld:"ALMACENDIRECCION",gxz:"Z144almacendireccion",gxold:"O144almacendireccion",gxvar:"A144almacendireccion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A144almacendireccion=n)},v2z:function(n){n!==undefined&&(gx.O.Z144almacendireccion=n)},v2c:function(n){gx.fn.setGridControlValue("ALMACENDIRECCION",n||gx.fn.currentGridRowImpl(11),gx.O.A144almacendireccion,0)},c2v:function(){this.val()!==undefined&&(gx.O.A144almacendireccion=this.val())},val:function(n){return gx.fn.getGridControlValue("ALMACENDIRECCION",n||gx.fn.currentGridRowImpl(11))},nac:gx.falseFn};t[15]={lvl:2,type:"svchar",len:50,dec:0,sign:!1,ro:1,isacc:0,grid:11,gxgrid:this.AlamacengridContainer,fnc:null,isvalid:null,rgrid:[],fld:"ALMACENMUNICIPIO",gxz:"Z146almacenmunicipio",gxold:"O146almacenmunicipio",gxvar:"A146almacenmunicipio",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A146almacenmunicipio=n)},v2z:function(n){n!==undefined&&(gx.O.Z146almacenmunicipio=n)},v2c:function(n){gx.fn.setGridControlValue("ALMACENMUNICIPIO",n||gx.fn.currentGridRowImpl(11),gx.O.A146almacenmunicipio,0)},c2v:function(){this.val()!==undefined&&(gx.O.A146almacenmunicipio=this.val())},val:function(n){return gx.fn.getGridControlValue("ALMACENMUNICIPIO",n||gx.fn.currentGridRowImpl(11))},nac:gx.falseFn};t[16]={lvl:2,type:"svchar",len:50,dec:0,sign:!1,ro:1,isacc:0,grid:11,gxgrid:this.AlamacengridContainer,fnc:null,isvalid:null,rgrid:[],fld:"ALAMCENESTADO",gxz:"Z147alamcenestado",gxold:"O147alamcenestado",gxvar:"A147alamcenestado",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A147alamcenestado=n)},v2z:function(n){n!==undefined&&(gx.O.Z147alamcenestado=n)},v2c:function(n){gx.fn.setGridControlValue("ALAMCENESTADO",n||gx.fn.currentGridRowImpl(11),gx.O.A147alamcenestado,0)},c2v:function(){this.val()!==undefined&&(gx.O.A147alamcenestado=this.val())},val:function(n){return gx.fn.getGridControlValue("ALAMCENESTADO",n||gx.fn.currentGridRowImpl(11))},nac:gx.falseFn};t[17]={lvl:2,type:"int",len:10,dec:0,sign:!1,pic:"ZZZZZZZZZ9",ro:1,isacc:0,grid:11,gxgrid:this.AlamacengridContainer,fnc:null,isvalid:null,rgrid:[],fld:"ALMACENTELEFONO",gxz:"Z149almacentelefono",gxold:"O149almacentelefono",gxvar:"A149almacentelefono",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A149almacentelefono=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z149almacentelefono=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ALMACENTELEFONO",n||gx.fn.currentGridRowImpl(11),gx.O.A149almacentelefono,0)},c2v:function(){this.val()!==undefined&&(gx.O.A149almacentelefono=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("ALMACENTELEFONO",n||gx.fn.currentGridRowImpl(11),".")},nac:gx.falseFn};t[18]={lvl:2,type:"svchar",len:5,dec:0,sign:!1,ro:1,isacc:0,grid:11,gxgrid:this.AlamacengridContainer,fnc:null,isvalid:null,rgrid:[],fld:"ALAMCENCODIGOPOSTAL",gxz:"Z148alamcencodigopostal",gxold:"O148alamcencodigopostal",gxvar:"A148alamcencodigopostal",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A148alamcencodigopostal=n)},v2z:function(n){n!==undefined&&(gx.O.Z148alamcencodigopostal=n)},v2c:function(n){gx.fn.setGridControlValue("ALAMCENCODIGOPOSTAL",n||gx.fn.currentGridRowImpl(11),gx.O.A148alamcencodigopostal,0)},c2v:function(){this.val()!==undefined&&(gx.O.A148alamcencodigopostal=this.val())},val:function(n){return gx.fn.getGridControlValue("ALAMCENCODIGOPOSTAL",n||gx.fn.currentGridRowImpl(11))},nac:gx.falseFn};t[19]={lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:11,gxgrid:this.AlamacengridContainer,fnc:null,isvalid:null,rgrid:[],fld:"vUPDATEIMAGE",gxz:"ZV7updateImage",gxold:"OV7updateImage",gxvar:"AV7updateImage",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV7updateImage=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7updateImage=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vUPDATEIMAGE",n||gx.fn.currentGridRowImpl(11),gx.O.AV7updateImage,gx.O.AV10Updateimage_GXI)},c2v:function(){gx.O.AV10Updateimage_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV7updateImage=this.val())},val:function(n){return gx.fn.getGridControlValue("vUPDATEIMAGE",n||gx.fn.currentGridRowImpl(11))},val_GXI:function(n){return gx.fn.getGridControlValue("vUPDATEIMAGE_GXI",n||gx.fn.currentGridRowImpl(11))},gxvar_GXI:"AV10Updateimage_GXI",nac:gx.falseFn};t[20]={lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:11,gxgrid:this.AlamacengridContainer,fnc:null,isvalid:null,rgrid:[],fld:"vDELETEIMAGE",gxz:"ZV6deleteImage",gxold:"OV6deleteImage",gxvar:"AV6deleteImage",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV6deleteImage=n)},v2z:function(n){n!==undefined&&(gx.O.ZV6deleteImage=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vDELETEIMAGE",n||gx.fn.currentGridRowImpl(11),gx.O.AV6deleteImage,gx.O.AV11Deleteimage_GXI)},c2v:function(){gx.O.AV11Deleteimage_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV6deleteImage=this.val())},val:function(n){return gx.fn.getGridControlValue("vDELETEIMAGE",n||gx.fn.currentGridRowImpl(11))},val_GXI:function(n){return gx.fn.getGridControlValue("vDELETEIMAGE_GXI",n||gx.fn.currentGridRowImpl(11))},gxvar_GXI:"AV11Deleteimage_GXI",nac:gx.falseFn};this.AV5buscar="";this.ZV5buscar="";this.OV5buscar="";this.Z19almacenid=0;this.O19almacenid=0;this.Z143almacendsc="";this.O143almacendsc="";this.Z144almacendireccion="";this.O144almacendireccion="";this.Z146almacenmunicipio="";this.O146almacenmunicipio="";this.Z147alamcenestado="";this.O147alamcenestado="";this.Z149almacentelefono=0;this.O149almacentelefono=0;this.Z148alamcencodigopostal="";this.O148alamcencodigopostal="";this.ZV7updateImage="";this.OV7updateImage="";this.ZV6deleteImage="";this.OV6deleteImage="";this.AV5buscar="";this.A19almacenid=0;this.A143almacendsc="";this.A144almacendireccion="";this.A146almacenmunicipio="";this.A147alamcenestado="";this.A149almacentelefono=0;this.A148alamcencodigopostal="";this.AV7updateImage="";this.AV6deleteImage="";this.Events={e13372_client:["VUPDATEIMAGE.CLICK",!0],e14372_client:["VDELETEIMAGE.CLICK",!0],e11372_client:["ENTER",!0],e16372_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"ALAMACENGRID_nFirstRecordOnPage",nv:0},{av:"ALAMACENGRID_nEOF",nv:0},{av:"AV5buscar",fld:"vBUSCAR",pic:"",nv:""},{av:"AV7updateImage",fld:"vUPDATEIMAGE",pic:"",nv:""},{av:"AV6deleteImage",fld:"vDELETEIMAGE",pic:"",nv:""}],[]];this.EvtParms["VUPDATEIMAGE.CLICK"]=[[{av:"A19almacenid",fld:"ALMACENID",pic:"ZZZZZZZZ9",hsh:!0,nv:0}],[]];this.EvtParms["VDELETEIMAGE.CLICK"]=[[{av:"A19almacenid",fld:"ALMACENID",pic:"ZZZZZZZZ9",hsh:!0,nv:0}],[]];this.EvtParms.ENTER=[[],[]];this.EnterCtrl=["BUTTON1"];n.addRefreshingVar(this.GXValidFnc[5]);n.addRefreshingVar({rfrVar:"AV7updateImage",rfrProp:"Value",gxAttId:"Updateimage"});n.addRefreshingVar({rfrVar:"AV6deleteImage",rfrProp:"Value",gxAttId:"Deleteimage"});this.InitStandaloneVars()});gx.createParentObj(detallesalmacen)