/**@preserve  GeneXus C# 10_3_15-115824 on 1/25/2022 17:35:41.8
*/
gx.evt.autoSkip=!1;gx.define("gx00h0",!1,function(){var n,t;this.ServerClass="gx00h0";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV12pareaareaid=gx.fn.getIntegerValue("vPAREAAREAID",".")};this.e17281_client=function(){this.clearMessages();gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle"));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}])};this.e11281_client=function(){this.clearMessages();gx.fn.getCtrlProperty("AREAAREAIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("AREAAREAIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCAREAAREAID","Visible",!0)):(gx.fn.setCtrlProperty("AREAAREAIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCAREAAREAID","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("AREAAREAIDFILTERCONTAINER","Class")',ctrl:"AREAAREAIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCAREAAREAID","Visible")',ctrl:"vCAREAAREAID",prop:"Visible"}])};this.e12281_client=function(){this.clearMessages();gx.fn.getCtrlProperty("AREADSCFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("AREADSCFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCAREADSC","Visible",!0)):(gx.fn.setCtrlProperty("AREADSCFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCAREADSC","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("AREADSCFILTERCONTAINER","Class")',ctrl:"AREADSCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCAREADSC","Visible")',ctrl:"vCAREADSC",prop:"Visible"}])};this.e13281_client=function(){this.clearMessages();gx.fn.getCtrlProperty("AREASTATUSADSCFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("AREASTATUSADSCFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCAREASTATUSADSC","Visible",!0)):(gx.fn.setCtrlProperty("AREASTATUSADSCFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCAREASTATUSADSC","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("AREASTATUSADSCFILTERCONTAINER","Class")',ctrl:"AREASTATUSADSCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCAREASTATUSADSC","Visible")',ctrl:"vCAREASTATUSADSC",prop:"Visible"}])};this.e14281_client=function(){this.clearMessages();gx.fn.getCtrlProperty("AREAUSUARIOFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("AREAUSUARIOFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCAREAUSUARIO","Visible",!0)):(gx.fn.setCtrlProperty("AREAUSUARIOFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCAREAUSUARIO","Visible",!1));this.refreshOutputs([{av:'gx.fn.getCtrlProperty("AREAUSUARIOFILTERCONTAINER","Class")',ctrl:"AREAUSUARIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCAREAUSUARIO","Visible")',ctrl:"vCAREAUSUARIO",prop:"Visible"}])};this.e15281_client=function(){this.clearMessages();gx.fn.getCtrlProperty("AREAFECREGFILTERCONTAINER","Class")=="AdvancedContainerItem"?gx.fn.setCtrlProperty("AREAFECREGFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"):gx.fn.setCtrlProperty("AREAFECREGFILTERCONTAINER","Class","AdvancedContainerItem");this.refreshOutputs([{av:'gx.fn.getCtrlProperty("AREAFECREGFILTERCONTAINER","Class")',ctrl:"AREAFECREGFILTERCONTAINER",prop:"Class"}])};this.e16281_client=function(){this.clearMessages();gx.fn.getCtrlProperty("AREAFECULTACTFILTERCONTAINER","Class")=="AdvancedContainerItem"?gx.fn.setCtrlProperty("AREAFECULTACTFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"):gx.fn.setCtrlProperty("AREAFECULTACTFILTERCONTAINER","Class","AdvancedContainerItem");this.refreshOutputs([{av:'gx.fn.getCtrlProperty("AREAFECULTACTFILTERCONTAINER","Class")',ctrl:"AREAFECULTACTFILTERCONTAINER",prop:"Class"}])};this.e20282_client=function(){this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e21281_client=function(){this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,72,73,75,76,77,78,79,80];this.GXLastCtrlId=80;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",74,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx00h0",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px","Nueva fila",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1]);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",75,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(22,76,"AREAAREAID","areaid","","areaareaid","int",0,"px",9,9,"right",null,[],22,"areaareaid",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(27,77,"AREADSC","areadsc","","areadsc","svchar",0,"px",100,80,"left",null,[],27,"areadsc",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addSingleLineEdit(29,78,"AREAUSUARIO","areausuario","","areausuario","svchar",0,"px",15,15,"left",null,[],29,"areausuario",!0,0,!1,!1,"Attribute",1,"WWColumn OptionalColumn");this.setGrid(t);n[2]={fld:"",grid:0};n[3]={fld:"MAIN",grid:0};n[4]={fld:"",grid:0};n[5]={fld:"",grid:0};n[6]={fld:"ADVANCEDCONTAINER",grid:0};n[7]={fld:"",grid:0};n[8]={fld:"",grid:0};n[9]={fld:"AREAAREAIDFILTERCONTAINER",grid:0};n[10]={fld:"",grid:0};n[11]={fld:"",grid:0};n[12]={fld:"LBLAREAAREAIDFILTER",format:1,grid:0};n[13]={fld:"",grid:0};n[14]={fld:"",grid:0};n[15]={fld:"",grid:0};n[16]={lvl:0,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCAREAAREAID",gxz:"ZV6careaareaid",gxold:"OV6careaareaid",gxvar:"AV6careaareaid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6careaareaid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6careaareaid=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCAREAAREAID",gx.O.AV6careaareaid,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6careaareaid=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCAREAAREAID",".")},nac:gx.falseFn};n[17]={fld:"",grid:0};n[18]={fld:"",grid:0};n[19]={fld:"AREADSCFILTERCONTAINER",grid:0};n[20]={fld:"",grid:0};n[21]={fld:"",grid:0};n[22]={fld:"LBLAREADSCFILTER",format:1,grid:0};n[23]={fld:"",grid:0};n[24]={fld:"",grid:0};n[25]={fld:"",grid:0};n[26]={lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCAREADSC",gxz:"ZV7careadsc",gxold:"OV7careadsc",gxvar:"AV7careadsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7careadsc=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7careadsc=n)},v2c:function(){gx.fn.setControlValue("vCAREADSC",gx.O.AV7careadsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7careadsc=this.val())},val:function(){return gx.fn.getControlValue("vCAREADSC")},nac:gx.falseFn};n[27]={fld:"",grid:0};n[28]={fld:"",grid:0};n[29]={fld:"AREASTATUSADSCFILTERCONTAINER",grid:0};n[30]={fld:"",grid:0};n[31]={fld:"",grid:0};n[32]={fld:"LBLAREASTATUSADSCFILTER",format:1,grid:0};n[33]={fld:"",grid:0};n[34]={fld:"",grid:0};n[35]={fld:"",grid:0};n[36]={lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCAREASTATUSADSC",gxz:"ZV8careastatusadsc",gxold:"OV8careastatusadsc",gxvar:"AV8careastatusadsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV8careastatusadsc=n)},v2z:function(n){n!==undefined&&(gx.O.ZV8careastatusadsc=n)},v2c:function(){gx.fn.setControlValue("vCAREASTATUSADSC",gx.O.AV8careastatusadsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV8careastatusadsc=this.val())},val:function(){return gx.fn.getControlValue("vCAREASTATUSADSC")},nac:gx.falseFn};n[37]={fld:"",grid:0};n[38]={fld:"",grid:0};n[39]={fld:"AREAUSUARIOFILTERCONTAINER",grid:0};n[40]={fld:"",grid:0};n[41]={fld:"",grid:0};n[42]={fld:"LBLAREAUSUARIOFILTER",format:1,grid:0};n[43]={fld:"",grid:0};n[44]={fld:"",grid:0};n[45]={fld:"",grid:0};n[46]={lvl:0,type:"svchar",len:15,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCAREAUSUARIO",gxz:"ZV9careausuario",gxold:"OV9careausuario",gxvar:"AV9careausuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV9careausuario=n)},v2z:function(n){n!==undefined&&(gx.O.ZV9careausuario=n)},v2c:function(){gx.fn.setControlValue("vCAREAUSUARIO",gx.O.AV9careausuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV9careausuario=this.val())},val:function(){return gx.fn.getControlValue("vCAREAUSUARIO")},nac:gx.falseFn};n[47]={fld:"",grid:0};n[48]={fld:"",grid:0};n[49]={fld:"AREAFECREGFILTERCONTAINER",grid:0};n[50]={fld:"",grid:0};n[51]={fld:"",grid:0};n[52]={fld:"LBLAREAFECREGFILTER",format:1,grid:0};n[53]={fld:"",grid:0};n[54]={fld:"",grid:0};n[55]={fld:"",grid:0};n[56]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCAREAFECREG",gxz:"ZV10careafecreg",gxold:"OV10careafecreg",gxvar:"AV10careafecreg",dp:{f:-1,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV10careafecreg=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV10careafecreg=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("vCAREAFECREG",gx.O.AV10careafecreg,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV10careafecreg=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("vCAREAFECREG")},nac:gx.falseFn};n[57]={fld:"",grid:0};n[58]={fld:"",grid:0};n[59]={fld:"AREAFECULTACTFILTERCONTAINER",grid:0};n[60]={fld:"",grid:0};n[61]={fld:"",grid:0};n[62]={fld:"LBLAREAFECULTACTFILTER",format:1,grid:0};n[63]={fld:"",grid:0};n[64]={fld:"",grid:0};n[65]={fld:"",grid:0};n[66]={lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCAREAFECULTACT",gxz:"ZV11careafecultact",gxold:"OV11careafecultact",gxvar:"AV11careafecultact",dp:{f:-1,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV11careafecultact=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.ZV11careafecultact=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("vCAREAFECULTACT",gx.O.AV11careafecultact,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV11careafecultact=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("vCAREAFECULTACT")},nac:gx.falseFn};n[67]={fld:"",grid:0};n[68]={fld:"GRIDTABLE",grid:0};n[69]={fld:"",grid:0};n[70]={fld:"",grid:0};n[72]={fld:"",grid:0};n[73]={fld:"",grid:0};n[75]={lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(74),gx.O.AV5LinkSelection,gx.O.AV16Linkselection_GXI)},c2v:function(){gx.O.AV16Linkselection_GXI=this.val_GXI();this.val()!==undefined&&(gx.O.AV5LinkSelection=this.val())},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(74))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(74))},gxvar_GXI:"AV16Linkselection_GXI",nac:gx.falseFn};n[76]={lvl:2,type:"int",len:9,dec:0,sign:!1,pic:"ZZZZZZZZ9",ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"AREAAREAID",gxz:"Z22areaareaid",gxold:"O22areaareaid",gxvar:"A22areaareaid",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A22areaareaid=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z22areaareaid=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("AREAAREAID",n||gx.fn.currentGridRowImpl(74),gx.O.A22areaareaid,0)},c2v:function(){this.val()!==undefined&&(gx.O.A22areaareaid=gx.num.intval(this.val()))},val:function(n){return gx.fn.getGridIntegerValue("AREAAREAID",n||gx.fn.currentGridRowImpl(74),".")},nac:gx.falseFn};n[77]={lvl:2,type:"svchar",len:100,dec:0,sign:!1,ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"AREADSC",gxz:"Z27areadsc",gxold:"O27areadsc",gxvar:"A27areadsc",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A27areadsc=n)},v2z:function(n){n!==undefined&&(gx.O.Z27areadsc=n)},v2c:function(n){gx.fn.setGridControlValue("AREADSC",n||gx.fn.currentGridRowImpl(74),gx.O.A27areadsc,0)},c2v:function(){this.val()!==undefined&&(gx.O.A27areadsc=this.val())},val:function(n){return gx.fn.getGridControlValue("AREADSC",n||gx.fn.currentGridRowImpl(74))},nac:gx.falseFn};n[78]={lvl:2,type:"svchar",len:15,dec:0,sign:!1,ro:1,isacc:0,grid:74,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"AREAUSUARIO",gxz:"Z29areausuario",gxold:"O29areausuario",gxvar:"A29areausuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A29areausuario=n)},v2z:function(n){n!==undefined&&(gx.O.Z29areausuario=n)},v2c:function(n){gx.fn.setGridControlValue("AREAUSUARIO",n||gx.fn.currentGridRowImpl(74),gx.O.A29areausuario,0)},c2v:function(){this.val()!==undefined&&(gx.O.A29areausuario=this.val())},val:function(n){return gx.fn.getGridControlValue("AREAUSUARIO",n||gx.fn.currentGridRowImpl(74))},nac:gx.falseFn};n[79]={fld:"",grid:0};n[80]={fld:"",grid:0};this.AV6careaareaid=0;this.ZV6careaareaid=0;this.OV6careaareaid=0;this.AV7careadsc="";this.ZV7careadsc="";this.OV7careadsc="";this.AV8careastatusadsc="";this.ZV8careastatusadsc="";this.OV8careastatusadsc="";this.AV9careausuario="";this.ZV9careausuario="";this.OV9careausuario="";this.AV10careafecreg=gx.date.nullDate();this.ZV10careafecreg=gx.date.nullDate();this.OV10careafecreg=gx.date.nullDate();this.AV11careafecultact=gx.date.nullDate();this.ZV11careafecultact=gx.date.nullDate();this.OV11careafecultact=gx.date.nullDate();this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z22areaareaid=0;this.O22areaareaid=0;this.Z27areadsc="";this.O27areadsc="";this.Z29areausuario="";this.O29areausuario="";this.AV6careaareaid=0;this.AV7careadsc="";this.AV8careastatusadsc="";this.AV9careausuario="";this.AV10careafecreg=gx.date.nullDate();this.AV11careafecultact=gx.date.nullDate();this.AV12pareaareaid=0;this.A31areafecultact=gx.date.nullDate();this.A30areafecreg=gx.date.nullDate();this.A28areastatusadsc="";this.AV5LinkSelection="";this.A22areaareaid=0;this.A27areadsc="";this.A29areausuario="";this.Events={e20282_client:["ENTER",!0],e21281_client:["CANCEL",!0],e17281_client:["'TOGGLE'",!1],e11281_client:["LBLAREAAREAIDFILTER.CLICK",!1],e12281_client:["LBLAREADSCFILTER.CLICK",!1],e13281_client:["LBLAREASTATUSADSCFILTER.CLICK",!1],e14281_client:["LBLAREAUSUARIOFILTER.CLICK",!1],e15281_client:["LBLAREAFECREGFILTER.CLICK",!1],e16281_client:["LBLAREAFECULTACTFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6careaareaid",fld:"vCAREAAREAID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7careadsc",fld:"vCAREADSC",pic:"",nv:""},{av:"AV8careastatusadsc",fld:"vCAREASTATUSADSC",pic:"",nv:""},{av:"AV9careausuario",fld:"vCAREAUSUARIO",pic:"",nv:""},{av:"AV10careafecreg",fld:"vCAREAFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV11careafecultact",fld:"vCAREAFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLAREAAREAIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("AREAAREAIDFILTERCONTAINER","Class")',ctrl:"AREAAREAIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("AREAAREAIDFILTERCONTAINER","Class")',ctrl:"AREAAREAIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCAREAAREAID","Visible")',ctrl:"vCAREAAREAID",prop:"Visible"}]];this.EvtParms["LBLAREADSCFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("AREADSCFILTERCONTAINER","Class")',ctrl:"AREADSCFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("AREADSCFILTERCONTAINER","Class")',ctrl:"AREADSCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCAREADSC","Visible")',ctrl:"vCAREADSC",prop:"Visible"}]];this.EvtParms["LBLAREASTATUSADSCFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("AREASTATUSADSCFILTERCONTAINER","Class")',ctrl:"AREASTATUSADSCFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("AREASTATUSADSCFILTERCONTAINER","Class")',ctrl:"AREASTATUSADSCFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCAREASTATUSADSC","Visible")',ctrl:"vCAREASTATUSADSC",prop:"Visible"}]];this.EvtParms["LBLAREAUSUARIOFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("AREAUSUARIOFILTERCONTAINER","Class")',ctrl:"AREAUSUARIOFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("AREAUSUARIOFILTERCONTAINER","Class")',ctrl:"AREAUSUARIOFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCAREAUSUARIO","Visible")',ctrl:"vCAREAUSUARIO",prop:"Visible"}]];this.EvtParms["LBLAREAFECREGFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("AREAFECREGFILTERCONTAINER","Class")',ctrl:"AREAFECREGFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("AREAFECREGFILTERCONTAINER","Class")',ctrl:"AREAFECREGFILTERCONTAINER",prop:"Class"}]];this.EvtParms["LBLAREAFECULTACTFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("AREAFECULTACTFILTERCONTAINER","Class")',ctrl:"AREAFECULTACTFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("AREAFECULTACTFILTERCONTAINER","Class")',ctrl:"AREAFECULTACTFILTERCONTAINER",prop:"Class"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:"",nv:""}]];this.EvtParms.ENTER=[[{av:"A22areaareaid",fld:"AREAAREAID",pic:"ZZZZZZZZ9",hsh:!0,nv:0}],[{av:"AV12pareaareaid",fld:"vPAREAAREAID",pic:"ZZZZZZZZ9",nv:0}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6careaareaid",fld:"vCAREAAREAID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7careadsc",fld:"vCAREADSC",pic:"",nv:""},{av:"AV8careastatusadsc",fld:"vCAREASTATUSADSC",pic:"",nv:""},{av:"AV9careausuario",fld:"vCAREAUSUARIO",pic:"",nv:""},{av:"AV10careafecreg",fld:"vCAREAFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV11careafecultact",fld:"vCAREAFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6careaareaid",fld:"vCAREAAREAID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7careadsc",fld:"vCAREADSC",pic:"",nv:""},{av:"AV8careastatusadsc",fld:"vCAREASTATUSADSC",pic:"",nv:""},{av:"AV9careausuario",fld:"vCAREAUSUARIO",pic:"",nv:""},{av:"AV10careafecreg",fld:"vCAREAFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV11careafecultact",fld:"vCAREAFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6careaareaid",fld:"vCAREAAREAID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7careadsc",fld:"vCAREADSC",pic:"",nv:""},{av:"AV8careastatusadsc",fld:"vCAREASTATUSADSC",pic:"",nv:""},{av:"AV9careausuario",fld:"vCAREAUSUARIO",pic:"",nv:""},{av:"AV10careafecreg",fld:"vCAREAFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV11careafecultact",fld:"vCAREAFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage",nv:0},{av:"GRID1_nEOF",nv:0},{av:"subGrid1_Rows",nv:0},{av:"AV6careaareaid",fld:"vCAREAAREAID",pic:"ZZZZZZZZ9",nv:0},{av:"AV7careadsc",fld:"vCAREADSC",pic:"",nv:""},{av:"AV8careastatusadsc",fld:"vCAREASTATUSADSC",pic:"",nv:""},{av:"AV9careausuario",fld:"vCAREAUSUARIO",pic:"",nv:""},{av:"AV10careafecreg",fld:"vCAREAFECREG",pic:"99/99/9999 99:99:99",nv:""},{av:"AV11careafecultact",fld:"vCAREAFECULTACT",pic:"99/99/9999 99:99:99",nv:""}],[]];this.setVCMap("AV12pareaareaid","vPAREAAREAID",0,"int");t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingVar(this.GXValidFnc[36]);t.addRefreshingVar(this.GXValidFnc[46]);t.addRefreshingVar(this.GXValidFnc[56]);t.addRefreshingVar(this.GXValidFnc[66]);this.InitStandaloneVars()});gx.createParentObj(gx00h0)