/**@preserve  GeneXus C# 10_3_15-115824 on 2/15/2022 5:9:38.29
*/
gx.evt.autoSkip=!1;gx.define("gx0080",!1,function(){var n,t;this.ServerClass="gx0080";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV11pmarcasid=gx.fn.getIntegerValue("vPMARCASID",".")};this.e161x1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle"));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}])};this.e111x1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("MARCASIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("MARCASIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCMARCASID","Visible",!0)):(gx.fn.setCtrlProperty("MARCASIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCMARCASID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("MARCASIDFILTERCONTAINER","Class")',ctrl:"MARCASIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMARCASID","Visible")',ctrl:"vCMARCASID",prop:"Visible"}])};this.e121x1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("MARCASDSCFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("MARCASDSCFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCMARCASDSC","Visible",!0)):(gx.fn.setCtrlProperty("MARCASDSCFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCMARCASDSC","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("MARCASDSCFILTERCONTAINER","Class")',ctrl:"MARCASDSCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMARCASDSC","Visible")',ctrl:"vCMARCASDSC",prop:"Visible"}])};this.e131x1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("MARCASUSUARIOFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("MARCASUSUARIOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCMARCASUSUARIO","Visible",!0)):(gx.fn.setCtrlProperty("MARCASUSUARIOFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCMARCASUSUARIO","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("MARCASUSUARIOFILTERCONTAINER","Class")',ctrl:"MARCASUSUARIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMARCASUSUARIO","Visible")',ctrl:"vCMARCASUSUARIO",prop:"Visible"}])};this.e141x1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("MARCASFECREGFILTERCONTAINER","Class")=="AdvancedContainerItem"?gx.fn.setCtrlProperty("MARCASFECREGFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"):gx.fn.setCtrlProperty("MARCASFECREGFILTERCONTAINER","Class","AdvancedContainerItem");this.refreshOutputs([{av:'gx.fn.getCtrlProperty("MARCASFECREGFILTERCONTAINER","Class")',ctrl:"MARCASFECREGFILTERCONTAINER",prop:"Class"}])};this.e151x1_client=function(){this.clearMessages();gx.fn.getCtrlProperty("MARCASFECULTACTFILTERCONTAINER","Class")=="AdvancedContainerItem"?gx.fn.setCtrlProperty("MARCASFECULTACTFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"):gx.fn.setCtrlProperty("MARCASFECULTACTFILTERCONTAINER","Class","AdvancedContainerItem");this.refreshOutputs([{av:'gx.fn.getCtrlProperty("MARCASFECULTACTFILTERCONTAINER","Class")',ctrl:"MARCASFECULTACTFILTERCONTAINER",prop:"Class"}])};this.e191x2_client=function(){this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e201x1_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,62,63,65,66,67,68,69,70];this.GXLastCtrlId=70;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",64,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0080",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1]);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",65,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(24,66,"MARCASID","marcasid","","marcasid","int",0,"px",9,9,"right",null,[],24,"marcasid",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(112,67,"MARCASDSC","marcasdsc","","marcasdsc","svchar",0,"px",100,80,"left",null,[],112,"marcasdsc",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(113,68,"MARCASUSUARIO","marcasusuario","","marcasusuario","svchar",0,"px",15,15,"left",null,[],113,"marcasusuario",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");this.setGrid(t);n[2]={fld:"",grid:0};n[3]={fld:"MAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"ADVANCEDCONTAINER",grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"MARCASIDFILTERCONTAINER",grid:0};n[10]={fld:"",grid:0};n[11]={fld:"",grid:0};n[12]={fld:"LBLMARCASIDFILTER",format:1,grid:0};n[13]={fld:"",grid:0};n[14]={fld:"",grid:0};n[15]={fld:"",grid:0};n[16]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCMARCASID",gxz:"ZV6cmarcasid",gxold:"OV6cmarcasid",gxvar:"AV6cmarcasid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cmarcasid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cmarcasid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCMARCASID",gx.O.AV6cmarcasid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cmarcasid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCMARCASID",".")},nac:gx.falseFn};n[17]={fld:"",grid:0};n[18]={fld:"",grid:0};n[19]={fld:"MARCASDSCFILTERCONTAINER",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={fld:"LBLMARCASDSCFILTER",format:1,grid:0};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCMARCASDSC",gxz:"ZV7cmarcasdsc",gxold:"OV7cmarcasdsc",gxvar:"AV7cmarcasdsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cmarcasdsc=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7cmarcasdsc=n)},v2c:function(){gx.fn.setControlValue("vCMARCASDSC",gx.O.AV7cmarcasdsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cmarcasdsc=this.val())},val:function(){return gx.fn.getControlValue("vCMARCASDSC")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"MARCASUSUARIOFILTERCONTAINER",grid:0};n[30]={fld:"",grid:0};n[31]={fld:"",grid:0};n[32]={fld:"LBLMARCASUSUARIOFILTER",format:1,grid:0};n[33]={fld:"",grid:0};n[34]={fld:"",grid:0};n[35]={fld:"",grid:0};n[36]={lvl:0,type:"svchar",len:15,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCMARCASUSUARIO",gxz:"ZV8cmarcasusuario",gxold:"OV8cmarcasusuario",gxvar:"AV8cmarcasusuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8cmarcasusuario=n)},v2z:function(n){n!==undefined&&(gx.O.ZV8cmarcasusuario=n)},v2c:function(){gx.fn.setControlValue("vCMARCASUSUARIO",gx.O.AV8cmarcasusuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8cmarcasusuario=this.val())},val:function(){return gx.fn.getControlValue("vCMARCASUSUARIO")},nac:gx.falseFn};n[37]={fld:"",grid:0};n[38]={fld:"",grid:0};n[39]={fld:"MARCASFECREGFILTERCONTAINER",grid:0};n[40]={fld:"",grid:0};n[41]={fld:"",grid:0};n[42]={fld:"LBLMARCASFECREGFILTER",format:1,grid:0};n[43]={fld:"",grid:0};n[44]={fld:"",grid:0};n[45]={fld:"",grid:0};n[46]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCMARCASFECREG",gxz:"ZV9cmarcasfecreg",gxold:"OV9cmarcasfecreg",gxvar:"AV9cmarcasfecreg",dp:{f:-1,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV9cmarcasfecreg=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV9cmarcasfecreg=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("vCMARCASFECREG",gx.O.AV9cmarcasfecreg,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV9cmarcasfecreg=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("vCMARCASFECREG")},nac:gx.falseFn};n[47]={fld:"",grid:0};n[48]={fld:"",grid:0};n[49]={fld:"MARCASFECULTACTFILTERCONTAINER",grid:0};n[50]={fld:"",grid:0};n[51]={fld:"",grid:0};n[52]={fld:"LBLMARCASFECULTACTFILTER",format:1,grid:0};n[53]={fld:"",grid:0};n[54]={fld:"",grid:0};n[55]={fld:"",grid:0};n[56]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCMARCASFECULTACT",gxz:"ZV10cmarcasfecultact",gxold:"OV10cmarcasfecultact",gxvar:"AV10cmarcasfecultact",dp:{f:-1,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10cmarcasfecultact=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV10cmarcasfecultact=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("vCMARCASFECULTACT",gx.O.AV10cmarcasfecultact,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV10cmarcasfecultact=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("vCMARCASFECULTACT")},nac:gx.falseFn};n[57]={fld:"",grid:0};n[58]={fld:"GRIDTABLE",grid:0};n[59]={fld:"",grid:0};n[60]={fld:"",grid:0};n[62]={fld:"",grid:0};n[63]={fld:"",grid:0};n[65]={lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(64),gx.O.AV5LinkSelection,gx.O.AV15Linkselection_GXI)},c2v:function(){gx.O.AV15Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(64))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(64))},gxvar_GXI:"AV15Linkselection_GXI",nac:gx.falseFn};n[66]={lvl:2,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"MARCASID",gxz:"Z24marcasid",gxold:"O24marcasid",gxvar:"A24marcasid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A24marcasid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z24marcasid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("MARCASID",n||gx.fn.currentGridRowImpl(64),gx.O.A24marcasid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A24marcasid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("MARCASID",n||gx.fn.currentGridRowImpl(64),".")},nac:gx.falseFn};n[67]={lvl:2,type:"svchar",len:100,dec:0,sign:!1,ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"MARCASDSC",gxz:"Z112marcasdsc",gxold:"O112marcasdsc",gxvar:"A112marcasdsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A112marcasdsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z112marcasdsc=n)},v2c:function(n){gx.fn.setGridControlValue("MARCASDSC",n||gx.fn.currentGridRowImpl(64),gx.O.A112marcasdsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A112marcasdsc=this.val())},val:function(n){return gx.fn.getGridControlValue("MARCASDSC",n||gx.fn.currentGridRowImpl(64))},nac:gx.falseFn};n[68]={lvl:2,type:"svchar",len:15,dec:0,sign:!1,ro:1,isacc:0,grid:64,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"MARCASUSUARIO",gxz:"Z113marcasusuario",gxold:"O113marcasusuario",gxvar:"A113marcasusuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A113marcasusuario=n)},v2z:function(n){n!==undefined&&(gx.O.Z113marcasusuario=n)},v2c:function(n){gx.fn.setGridControlValue("MARCASUSUARIO",n||gx.fn.currentGridRowImpl(64),gx.O.A113marcasusuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.A113marcasusuario=this.val())},val:function(n){return gx.fn.getGridControlValue("MARCASUSUARIO",n||gx.fn.currentGridRowImpl(64))},nac:gx.falseFn};n[69]={fld:"",grid:0};n[70]={fld:"",grid:0};this.AV6cmarcasid=0;this.ZV6cmarcasid=0;this.OV6cmarcasid=0;this.AV7cmarcasdsc="";this.ZV7cmarcasdsc="";this.OV7cmarcasdsc="";this.AV8cmarcasusuario="";this.ZV8cmarcasusuario="";this.OV8cmarcasusuario="";this.AV9cmarcasfecreg=gx.date.nullDate();this.ZV9cmarcasfecreg=gx.date.nullDate();this.OV9cmarcasfecreg=gx.date.nullDate();this.AV10cmarcasfecultact=gx.date.nullDate();this.ZV10cmarcasfecultact=gx.date.nullDate();this.OV10cmarcasfecultact=gx.date.nullDate();this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z24marcasid=0;this.O24marcasid=0;this.Z112marcasdsc="";this.O112marcasdsc="";this.Z113marcasusuario="";this.O113marcasusuario="";this.AV6cmarcasid=0;this.AV7cmarcasdsc="";this.AV8cmarcasusuario="";this.AV9cmarcasfecreg=gx.date.nullDate();this.AV10cmarcasfecultact=gx.date.nullDate();this.AV11pmarcasid=0;this.A115marcasfecultact=gx.date.nullDate();this.A114marcasfecreg=gx.date.nullDate();this.AV5LinkSelection="";this.A24marcasid=0;this.A112marcasdsc="";this.A113marcasusuario="";this.Events={e191x2_client:["ENTER",!0],e201x1_client:["CANCEL",!0],e161x1_client:["'TOGGLE'",!1],e111x1_client:["LBLMARCASIDFILTER.CLICK",!1],e121x1_client:["LBLMARCASDSCFILTER.CLICK",!1],e131x1_client:["LBLMARCASUSUARIOFILTER.CLICK",!1],e141x1_client:["LBLMARCASFECREGFILTER.CLICK",!1],e151x1_client:["LBLMARCASFECULTACTFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cmarcasid",fld:"vCMARCASID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cmarcasdsc",fld:"vCMARCASDSC",pic:"",nv:""},{av:"AV8cmarcasusuario",fld:"vCMARCASUSUARIO",pic:"",nv:""},{av:"AV9cmarcasfecreg",fld:"vCMARCASFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV10cmarcasfecultact",fld:"vCMARCASFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLMARCASIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("MARCASIDFILTERCONTAINER","Class")',ctrl:"MARCASIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("MARCASIDFILTERCONTAINER","Class")',ctrl:"MARCASIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMARCASID","Visible")',ctrl:"vCMARCASID",prop:"Visible"}]];this.EvtParms["LBLMARCASDSCFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("MARCASDSCFILTERCONTAINER","Class")',ctrl:"MARCASDSCFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("MARCASDSCFILTERCONTAINER","Class")',ctrl:"MARCASDSCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMARCASDSC","Visible")',ctrl:"vCMARCASDSC",prop:"Visible"}]];this.EvtParms["LBLMARCASUSUARIOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("MARCASUSUARIOFILTERCONTAINER","Class")',ctrl:"MARCASUSUARIOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("MARCASUSUARIOFILTERCONTAINER","Class")',ctrl:"MARCASUSUARIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCMARCASUSUARIO","Visible")',ctrl:"vCMARCASUSUARIO",prop:"Visible"}]];this.EvtParms["LBLMARCASFECREGFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("MARCASFECREGFILTERCONTAINER","Class")',ctrl:"MARCASFECREGFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("MARCASFECREGFILTERCONTAINER","Class")',ctrl:"MARCASFECREGFILTERCONTAINER",prop:"Class"}]];this.EvtParms["LBLMARCASFECULTACTFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("MARCASFECULTACTFILTERCONTAINER","Class")',ctrl:"MARCASFECULTACTFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("MARCASFECULTACTFILTERCONTAINER","Class")',ctrl:"MARCASFECULTACTFILTERCONTAINER",prop:"Class"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:"",nv:""}]];this.EvtParms.ENTER=[[{av:"A24marcasid",fld:"MARCASID",pic:"ZZZZZZZZ9",hsh:!0,nv:0}],[{av:"AV11pmarcasid",fld:"vPMARCASID",pic:"ZZZZZZZZ9",nv:0}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cmarcasid",fld:"vCMARCASID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cmarcasdsc",fld:"vCMARCASDSC",pic:"",nv:""},{av:"AV8cmarcasusuario",fld:"vCMARCASUSUARIO",pic:"",nv:""},{av:"AV9cmarcasfecreg",fld:"vCMARCASFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV10cmarcasfecultact",fld:"vCMARCASFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cmarcasid",fld:"vCMARCASID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cmarcasdsc",fld:"vCMARCASDSC",pic:"",nv:""},{av:"AV8cmarcasusuario",fld:"vCMARCASUSUARIO",pic:"",nv:""},{av:"AV9cmarcasfecreg",fld:"vCMARCASFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV10cmarcasfecultact",fld:"vCMARCASFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cmarcasid",fld:"vCMARCASID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cmarcasdsc",fld:"vCMARCASDSC",pic:"",nv:""},{av:"AV8cmarcasusuario",fld:"vCMARCASUSUARIO",pic:"",nv:""},{av:"AV9cmarcasfecreg",fld:"vCMARCASFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV10cmarcasfecultact",fld:"vCMARCASFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6cmarcasid",fld:"vCMARCASID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7cmarcasdsc",fld:"vCMARCASDSC",pic:"",nv:""},{av:"AV8cmarcasusuario",fld:"vCMARCASUSUARIO",pic:"",nv:""},{av:"AV9cmarcasfecreg",fld:"vCMARCASFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV10cmarcasfecultact",fld:"vCMARCASFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.setVCMap("AV11pmarcasid","vPMARCASID",0,"int");t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar(this.GXValidFnc[46]);t.addRefreshingVar(this.GXValidFnc[56]);this.InitStandaloneVars()});gx.createParentObj(gx0080)