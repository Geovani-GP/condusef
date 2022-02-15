/*
               File: type_Sdtempleados
        Description: empleados
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 2/15/2022 5:8:47.60
       Program type: Callable routine
          Main DBMS: postgresql
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using System.Web.Services.Protocols;
using System.Data;
using NpgsqlTypes;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Reflection;
using System.Xml.Serialization;
using System.Data.SqlTypes;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   [XmlSerializerFormat]
   [XmlRoot(ElementName = "empleados" )]
   [XmlType(TypeName =  "empleados" , Namespace = "Condufef_v1" )]
   [Serializable]
   public class Sdtempleados : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public Sdtempleados( )
      {
         /* Constructor for serialization */
         gxTv_Sdtempleados_Empleadosareaid = "";
         gxTv_Sdtempleados_Empleadosnomemple = "";
         gxTv_Sdtempleados_Empleadosappaterno = "";
         gxTv_Sdtempleados_Empleadosapmaterno = "";
         gxTv_Sdtempleados_Empleadosstatus = "";
         gxTv_Sdtempleados_Empleadosusuario = "";
         gxTv_Sdtempleados_Empleadoscorreo = "";
         gxTv_Sdtempleados_Empleadosext = "";
         gxTv_Sdtempleados_Empleadosfecreg = DateTime.MinValue;
         gxTv_Sdtempleados_Empleadosfecultact = DateTime.MinValue;
         gxTv_Sdtempleados_Mode = "";
         gxTv_Sdtempleados_Empleadosareaid_Z = "";
         gxTv_Sdtempleados_Empleadosnomemple_Z = "";
         gxTv_Sdtempleados_Empleadosappaterno_Z = "";
         gxTv_Sdtempleados_Empleadosapmaterno_Z = "";
         gxTv_Sdtempleados_Empleadosstatus_Z = "";
         gxTv_Sdtempleados_Empleadosusuario_Z = "";
         gxTv_Sdtempleados_Empleadoscorreo_Z = "";
         gxTv_Sdtempleados_Empleadosext_Z = "";
         gxTv_Sdtempleados_Empleadosfecreg_Z = DateTime.MinValue;
         gxTv_Sdtempleados_Empleadosfecultact_Z = DateTime.MinValue;
      }

      public Sdtempleados( IGxContext context )
      {
         this.context = context;
         constructorCallingAssembly = Assembly.GetCallingAssembly();
         initialize();
      }

      private static Hashtable mapper;
      public override String JsonMap( String value )
      {
         if ( mapper == null )
         {
            mapper = new Hashtable();
         }
         return (String)mapper[value]; ;
      }

      public void Load( int AV13empleadosid )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(int)AV13empleadosid});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"empleadosid", typeof(int)}}) ;
      }

      public override IGxCollection GetMessages( )
      {
         short item = 1 ;
         IGxCollection msgs = new GxObjectCollection( context, "Messages.Message", "Genexus", "SdtMessages_Message", "GeneXus.Programs") ;
         SdtMessages_Message m1 ;
         IGxSilentTrn trn = getTransaction() ;
         msglist msgList = trn.GetMessages() ;
         while ( item <= msgList.ItemCount )
         {
            m1 = new SdtMessages_Message(context);
            m1.gxTpr_Id = msgList.getItemValue(item);
            m1.gxTpr_Description = msgList.getItemText(item);
            m1.gxTpr_Type = msgList.getItemType(item);
            msgs.Add(m1, 0);
            item = (short)(item+1);
         }
         return msgs ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "empleados");
         metadata.Set("BT", "EMPLEADOS");
         metadata.Set("PK", "[ \"empleadosid\" ]");
         metadata.Set("AllowInsert", "True");
         metadata.Set("AllowUpdate", "True");
         metadata.Set("AllowDelete", "True");
         return metadata ;
      }

      public override String ToXml( bool includeHeader ,
                                    bool includeState ,
                                    String name ,
                                    String sNameSpace )
      {
         String s ;
         XmlSerializer xmls ;
         if ( ! includeState )
         {
            XmlAttributeOverrides ov = new XmlAttributeOverrides();
            XmlAttributes attrs = new XmlAttributes();
            attrs.XmlIgnore = true;
            ov.Add(this.GetType(),  "gxTpr_Mode" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Initialized" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Empleadosid_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Empleadosareaid_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Empleadosnomemple_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Empleadosappaterno_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Empleadosapmaterno_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Empleadosstatus_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Empleadosusuario_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Empleadoscorreo_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Empleadosext_Z" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Empleadosfecreg_Z_Nullable" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Empleadosfecultact_Z_Nullable" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Empleadosid_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Empleadosareaid_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Empleadosnomemple_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Empleadosappaterno_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Empleadosapmaterno_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Empleadosstatus_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Empleadosusuario_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Empleadoscorreo_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Empleadosext_N" , attrs);
            ov.Add(this.GetType(),  "gxTpr_Empleadosfecreg_N" , attrs);
            xmls = new XmlSerializer(this.GetType(), ov, new Type[0], null, sNameSpace);
         }
         else
         {
            xmls = new XmlSerializer(this.GetType(), sNameSpace);
         }
         System.IO.MemoryStream stream = new System.IO.MemoryStream();
         System.Xml.XmlWriter xmlw = System.Xml.XmlWriter.Create(stream, new System.Xml.XmlWriterSettings() { OmitXmlDeclaration = !includeHeader});
         XmlSerializerNamespaces xmlns = new XmlSerializerNamespaces();
         xmlns.Add(String.Empty, sNameSpace);
         xmls.Serialize( xmlw, this, xmlns);
         stream.Seek(0L, System.IO.SeekOrigin.Begin);
         System.IO.StreamReader sr = new System.IO.StreamReader(stream);
         s = sr.ReadToEnd();
         stream.Close();
         return s ;
      }

      public override void FromXml( String s ,
                                    String name )
      {
         Sdtempleados deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType(),  "Condufef_v1" );
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (Sdtempleados)(xmls.Deserialize( sr)) ;
         sr.Close();
         Sdtempleados obj ;
         obj = this;
         obj.gxTpr_Empleadosid = deserialized.gxTpr_Empleadosid;
         obj.gxTpr_Empleadosareaid = deserialized.gxTpr_Empleadosareaid;
         obj.gxTpr_Empleadosnomemple = deserialized.gxTpr_Empleadosnomemple;
         obj.gxTpr_Empleadosappaterno = deserialized.gxTpr_Empleadosappaterno;
         obj.gxTpr_Empleadosapmaterno = deserialized.gxTpr_Empleadosapmaterno;
         obj.gxTpr_Empleadosstatus = deserialized.gxTpr_Empleadosstatus;
         obj.gxTpr_Empleadosusuario = deserialized.gxTpr_Empleadosusuario;
         obj.gxTpr_Empleadoscorreo = deserialized.gxTpr_Empleadoscorreo;
         obj.gxTpr_Empleadosext = deserialized.gxTpr_Empleadosext;
         obj.gxTpr_Empleadosfecreg = deserialized.gxTpr_Empleadosfecreg;
         obj.gxTpr_Empleadosfecultact = deserialized.gxTpr_Empleadosfecultact;
         obj.gxTpr_Mode = deserialized.gxTpr_Mode;
         obj.gxTpr_Initialized = deserialized.gxTpr_Initialized;
         obj.gxTpr_Empleadosid_Z = deserialized.gxTpr_Empleadosid_Z;
         obj.gxTpr_Empleadosareaid_Z = deserialized.gxTpr_Empleadosareaid_Z;
         obj.gxTpr_Empleadosnomemple_Z = deserialized.gxTpr_Empleadosnomemple_Z;
         obj.gxTpr_Empleadosappaterno_Z = deserialized.gxTpr_Empleadosappaterno_Z;
         obj.gxTpr_Empleadosapmaterno_Z = deserialized.gxTpr_Empleadosapmaterno_Z;
         obj.gxTpr_Empleadosstatus_Z = deserialized.gxTpr_Empleadosstatus_Z;
         obj.gxTpr_Empleadosusuario_Z = deserialized.gxTpr_Empleadosusuario_Z;
         obj.gxTpr_Empleadoscorreo_Z = deserialized.gxTpr_Empleadoscorreo_Z;
         obj.gxTpr_Empleadosext_Z = deserialized.gxTpr_Empleadosext_Z;
         obj.gxTpr_Empleadosfecreg_Z = deserialized.gxTpr_Empleadosfecreg_Z;
         obj.gxTpr_Empleadosfecultact_Z = deserialized.gxTpr_Empleadosfecultact_Z;
         obj.gxTpr_Empleadosid_N = deserialized.gxTpr_Empleadosid_N;
         obj.gxTpr_Empleadosareaid_N = deserialized.gxTpr_Empleadosareaid_N;
         obj.gxTpr_Empleadosnomemple_N = deserialized.gxTpr_Empleadosnomemple_N;
         obj.gxTpr_Empleadosappaterno_N = deserialized.gxTpr_Empleadosappaterno_N;
         obj.gxTpr_Empleadosapmaterno_N = deserialized.gxTpr_Empleadosapmaterno_N;
         obj.gxTpr_Empleadosstatus_N = deserialized.gxTpr_Empleadosstatus_N;
         obj.gxTpr_Empleadosusuario_N = deserialized.gxTpr_Empleadosusuario_N;
         obj.gxTpr_Empleadoscorreo_N = deserialized.gxTpr_Empleadoscorreo_N;
         obj.gxTpr_Empleadosext_N = deserialized.gxTpr_Empleadosext_N;
         obj.gxTpr_Empleadosfecreg_N = deserialized.gxTpr_Empleadosfecreg_N;
         return  ;
      }

      public override short readxml( GXXMLReader oReader ,
                                     String sName )
      {
         short GXSoapError = 1 ;
         sTagName = oReader.Name;
         if ( oReader.IsSimple == 0 )
         {
            GXSoapError = oReader.Read();
            nOutParmCount = 0;
            while ( ( ( StringUtil.StrCmp(oReader.Name, sTagName) != 0 ) || ( oReader.NodeType == 1 ) ) && ( GXSoapError > 0 ) )
            {
               readOk = 0;
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadosid") )
               {
                  gxTv_Sdtempleados_Empleadosid = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadosareaid") )
               {
                  gxTv_Sdtempleados_Empleadosareaid = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadosnomemple") )
               {
                  gxTv_Sdtempleados_Empleadosnomemple = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadosappaterno") )
               {
                  gxTv_Sdtempleados_Empleadosappaterno = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadosapmaterno") )
               {
                  gxTv_Sdtempleados_Empleadosapmaterno = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadosstatus") )
               {
                  gxTv_Sdtempleados_Empleadosstatus = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadosusuario") )
               {
                  gxTv_Sdtempleados_Empleadosusuario = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadoscorreo") )
               {
                  gxTv_Sdtempleados_Empleadoscorreo = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadosext") )
               {
                  gxTv_Sdtempleados_Empleadosext = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadosfecreg") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtempleados_Empleadosfecreg = DateTime.MinValue;
                  }
                  else
                  {
                     gxTv_Sdtempleados_Empleadosfecreg = context.localUtil.YMDToD( (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadosfecultact") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtempleados_Empleadosfecultact = DateTime.MinValue;
                  }
                  else
                  {
                     gxTv_Sdtempleados_Empleadosfecultact = context.localUtil.YMDToD( (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Mode") )
               {
                  gxTv_Sdtempleados_Mode = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Initialized") )
               {
                  gxTv_Sdtempleados_Initialized = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadosid_Z") )
               {
                  gxTv_Sdtempleados_Empleadosid_Z = (int)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadosareaid_Z") )
               {
                  gxTv_Sdtempleados_Empleadosareaid_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadosnomemple_Z") )
               {
                  gxTv_Sdtempleados_Empleadosnomemple_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadosappaterno_Z") )
               {
                  gxTv_Sdtempleados_Empleadosappaterno_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadosapmaterno_Z") )
               {
                  gxTv_Sdtempleados_Empleadosapmaterno_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadosstatus_Z") )
               {
                  gxTv_Sdtempleados_Empleadosstatus_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadosusuario_Z") )
               {
                  gxTv_Sdtempleados_Empleadosusuario_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadoscorreo_Z") )
               {
                  gxTv_Sdtempleados_Empleadoscorreo_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadosext_Z") )
               {
                  gxTv_Sdtempleados_Empleadosext_Z = oReader.Value;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadosfecreg_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtempleados_Empleadosfecreg_Z = DateTime.MinValue;
                  }
                  else
                  {
                     gxTv_Sdtempleados_Empleadosfecreg_Z = context.localUtil.YMDToD( (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadosfecultact_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_Sdtempleados_Empleadosfecultact_Z = DateTime.MinValue;
                  }
                  else
                  {
                     gxTv_Sdtempleados_Empleadosfecultact_Z = context.localUtil.YMDToD( (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadosid_N") )
               {
                  gxTv_Sdtempleados_Empleadosid_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadosareaid_N") )
               {
                  gxTv_Sdtempleados_Empleadosareaid_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadosnomemple_N") )
               {
                  gxTv_Sdtempleados_Empleadosnomemple_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadosappaterno_N") )
               {
                  gxTv_Sdtempleados_Empleadosappaterno_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadosapmaterno_N") )
               {
                  gxTv_Sdtempleados_Empleadosapmaterno_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadosstatus_N") )
               {
                  gxTv_Sdtempleados_Empleadosstatus_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadosusuario_N") )
               {
                  gxTv_Sdtempleados_Empleadosusuario_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadoscorreo_N") )
               {
                  gxTv_Sdtempleados_Empleadoscorreo_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadosext_N") )
               {
                  gxTv_Sdtempleados_Empleadosext_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "empleadosfecreg_N") )
               {
                  gxTv_Sdtempleados_Empleadosfecreg_N = (short)(NumberUtil.Val( oReader.Value, "."));
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               nOutParmCount = (short)(nOutParmCount+1);
               if ( readOk == 0 )
               {
                  context.sSOAPErrMsg = context.sSOAPErrMsg + "Error reading " + sTagName + StringUtil.NewLine( );
                  context.sSOAPErrMsg = context.sSOAPErrMsg + "Message: " + oReader.ReadRawXML();
                  GXSoapError = (short)(nOutParmCount*-1);
               }
            }
         }
         return GXSoapError ;
      }

      public override void writexml( GXXMLWriter oWriter ,
                                     String sName ,
                                     String sNameSpace )
      {
         writexml(oWriter, sName, sNameSpace, true);
         return  ;
      }

      public override void writexml( GXXMLWriter oWriter ,
                                     String sName ,
                                     String sNameSpace ,
                                     bool sIncludeState )
      {
         if ( String.IsNullOrEmpty(StringUtil.RTrim( sName)) )
         {
            sName = "empleados";
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( sNameSpace)) )
         {
            sNameSpace = "Condufef_v1";
         }
         oWriter.WriteStartElement(sName);
         if ( StringUtil.StrCmp(StringUtil.Left( sNameSpace, 10), "[*:nosend]") != 0 )
         {
            oWriter.WriteAttribute("xmlns", sNameSpace);
         }
         else
         {
            sNameSpace = StringUtil.Right( sNameSpace, (short)(StringUtil.Len( sNameSpace)-10));
         }
         oWriter.WriteElement("empleadosid", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtempleados_Empleadosid), 9, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("empleadosareaid", StringUtil.RTrim( gxTv_Sdtempleados_Empleadosareaid));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("empleadosnomemple", StringUtil.RTrim( gxTv_Sdtempleados_Empleadosnomemple));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("empleadosappaterno", StringUtil.RTrim( gxTv_Sdtempleados_Empleadosappaterno));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("empleadosapmaterno", StringUtil.RTrim( gxTv_Sdtempleados_Empleadosapmaterno));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("empleadosstatus", StringUtil.RTrim( gxTv_Sdtempleados_Empleadosstatus));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("empleadosusuario", StringUtil.RTrim( gxTv_Sdtempleados_Empleadosusuario));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("empleadoscorreo", StringUtil.RTrim( gxTv_Sdtempleados_Empleadoscorreo));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         oWriter.WriteElement("empleadosext", StringUtil.RTrim( gxTv_Sdtempleados_Empleadosext));
         if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Condufef_v1");
         }
         if ( (DateTime.MinValue==gxTv_Sdtempleados_Empleadosfecreg) )
         {
            oWriter.WriteStartElement("empleadosfecreg");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtempleados_Empleadosfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtempleados_Empleadosfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtempleados_Empleadosfecreg)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            oWriter.WriteElement("empleadosfecreg", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
         }
         if ( (DateTime.MinValue==gxTv_Sdtempleados_Empleadosfecultact) )
         {
            oWriter.WriteStartElement("empleadosfecultact");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtempleados_Empleadosfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtempleados_Empleadosfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtempleados_Empleadosfecultact)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            oWriter.WriteElement("empleadosfecultact", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
         }
         if ( sIncludeState )
         {
            oWriter.WriteElement("Mode", StringUtil.RTrim( gxTv_Sdtempleados_Mode));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("Initialized", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtempleados_Initialized), 4, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("empleadosid_Z", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtempleados_Empleadosid_Z), 9, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("empleadosareaid_Z", StringUtil.RTrim( gxTv_Sdtempleados_Empleadosareaid_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("empleadosnomemple_Z", StringUtil.RTrim( gxTv_Sdtempleados_Empleadosnomemple_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("empleadosappaterno_Z", StringUtil.RTrim( gxTv_Sdtempleados_Empleadosappaterno_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("empleadosapmaterno_Z", StringUtil.RTrim( gxTv_Sdtempleados_Empleadosapmaterno_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("empleadosstatus_Z", StringUtil.RTrim( gxTv_Sdtempleados_Empleadosstatus_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("empleadosusuario_Z", StringUtil.RTrim( gxTv_Sdtempleados_Empleadosusuario_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("empleadoscorreo_Z", StringUtil.RTrim( gxTv_Sdtempleados_Empleadoscorreo_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("empleadosext_Z", StringUtil.RTrim( gxTv_Sdtempleados_Empleadosext_Z));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            if ( (DateTime.MinValue==gxTv_Sdtempleados_Empleadosfecreg_Z) )
            {
               oWriter.WriteStartElement("empleadosfecreg_Z");
               oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
               oWriter.WriteAttribute("xsi:nil", "true");
               oWriter.WriteEndElement();
            }
            else
            {
               sDateCnv = "";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtempleados_Empleadosfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtempleados_Empleadosfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtempleados_Empleadosfecreg_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               oWriter.WriteElement("empleadosfecreg_Z", sDateCnv);
               if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
               {
                  oWriter.WriteAttribute("xmlns", "Condufef_v1");
               }
            }
            if ( (DateTime.MinValue==gxTv_Sdtempleados_Empleadosfecultact_Z) )
            {
               oWriter.WriteStartElement("empleadosfecultact_Z");
               oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
               oWriter.WriteAttribute("xsi:nil", "true");
               oWriter.WriteEndElement();
            }
            else
            {
               sDateCnv = "";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtempleados_Empleadosfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtempleados_Empleadosfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               sDateCnv = sDateCnv + "-";
               sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtempleados_Empleadosfecultact_Z)), 10, 0));
               sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
               oWriter.WriteElement("empleadosfecultact_Z", sDateCnv);
               if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
               {
                  oWriter.WriteAttribute("xmlns", "Condufef_v1");
               }
            }
            oWriter.WriteElement("empleadosid_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtempleados_Empleadosid_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("empleadosareaid_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtempleados_Empleadosareaid_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("empleadosnomemple_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtempleados_Empleadosnomemple_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("empleadosappaterno_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtempleados_Empleadosappaterno_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("empleadosapmaterno_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtempleados_Empleadosapmaterno_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("empleadosstatus_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtempleados_Empleadosstatus_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("empleadosusuario_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtempleados_Empleadosusuario_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("empleadoscorreo_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtempleados_Empleadoscorreo_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("empleadosext_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtempleados_Empleadosext_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
            oWriter.WriteElement("empleadosfecreg_N", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_Sdtempleados_Empleadosfecreg_N), 1, 0)));
            if ( StringUtil.StrCmp(sNameSpace, "Condufef_v1") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Condufef_v1");
            }
         }
         oWriter.WriteEndElement();
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("empleadosid", gxTv_Sdtempleados_Empleadosid, false);
         AddObjectProperty("empleadosareaid", gxTv_Sdtempleados_Empleadosareaid, false);
         AddObjectProperty("empleadosnomemple", gxTv_Sdtempleados_Empleadosnomemple, false);
         AddObjectProperty("empleadosappaterno", gxTv_Sdtempleados_Empleadosappaterno, false);
         AddObjectProperty("empleadosapmaterno", gxTv_Sdtempleados_Empleadosapmaterno, false);
         AddObjectProperty("empleadosstatus", gxTv_Sdtempleados_Empleadosstatus, false);
         AddObjectProperty("empleadosusuario", gxTv_Sdtempleados_Empleadosusuario, false);
         AddObjectProperty("empleadoscorreo", gxTv_Sdtempleados_Empleadoscorreo, false);
         AddObjectProperty("empleadosext", gxTv_Sdtempleados_Empleadosext, false);
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtempleados_Empleadosfecreg)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtempleados_Empleadosfecreg)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtempleados_Empleadosfecreg)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("empleadosfecreg", sDateCnv, false);
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtempleados_Empleadosfecultact)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtempleados_Empleadosfecultact)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtempleados_Empleadosfecultact)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("empleadosfecultact", sDateCnv, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_Sdtempleados_Mode, false);
            AddObjectProperty("Initialized", gxTv_Sdtempleados_Initialized, false);
            AddObjectProperty("empleadosid_Z", gxTv_Sdtempleados_Empleadosid_Z, false);
            AddObjectProperty("empleadosareaid_Z", gxTv_Sdtempleados_Empleadosareaid_Z, false);
            AddObjectProperty("empleadosnomemple_Z", gxTv_Sdtempleados_Empleadosnomemple_Z, false);
            AddObjectProperty("empleadosappaterno_Z", gxTv_Sdtempleados_Empleadosappaterno_Z, false);
            AddObjectProperty("empleadosapmaterno_Z", gxTv_Sdtempleados_Empleadosapmaterno_Z, false);
            AddObjectProperty("empleadosstatus_Z", gxTv_Sdtempleados_Empleadosstatus_Z, false);
            AddObjectProperty("empleadosusuario_Z", gxTv_Sdtempleados_Empleadosusuario_Z, false);
            AddObjectProperty("empleadoscorreo_Z", gxTv_Sdtempleados_Empleadoscorreo_Z, false);
            AddObjectProperty("empleadosext_Z", gxTv_Sdtempleados_Empleadosext_Z, false);
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtempleados_Empleadosfecreg_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtempleados_Empleadosfecreg_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtempleados_Empleadosfecreg_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("empleadosfecreg_Z", sDateCnv, false);
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_Sdtempleados_Empleadosfecultact_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_Sdtempleados_Empleadosfecultact_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_Sdtempleados_Empleadosfecultact_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("empleadosfecultact_Z", sDateCnv, false);
            AddObjectProperty("empleadosid_N", gxTv_Sdtempleados_Empleadosid_N, false);
            AddObjectProperty("empleadosareaid_N", gxTv_Sdtempleados_Empleadosareaid_N, false);
            AddObjectProperty("empleadosnomemple_N", gxTv_Sdtempleados_Empleadosnomemple_N, false);
            AddObjectProperty("empleadosappaterno_N", gxTv_Sdtempleados_Empleadosappaterno_N, false);
            AddObjectProperty("empleadosapmaterno_N", gxTv_Sdtempleados_Empleadosapmaterno_N, false);
            AddObjectProperty("empleadosstatus_N", gxTv_Sdtempleados_Empleadosstatus_N, false);
            AddObjectProperty("empleadosusuario_N", gxTv_Sdtempleados_Empleadosusuario_N, false);
            AddObjectProperty("empleadoscorreo_N", gxTv_Sdtempleados_Empleadoscorreo_N, false);
            AddObjectProperty("empleadosext_N", gxTv_Sdtempleados_Empleadosext_N, false);
            AddObjectProperty("empleadosfecreg_N", gxTv_Sdtempleados_Empleadosfecreg_N, false);
         }
         return  ;
      }

      [  SoapElement( ElementName = "empleadosid" )]
      [  XmlElement( ElementName = "empleadosid"   )]
      public int gxTpr_Empleadosid
      {
         get {
            return gxTv_Sdtempleados_Empleadosid ;
         }

         set {
            if ( gxTv_Sdtempleados_Empleadosid != value )
            {
               gxTv_Sdtempleados_Mode = "INS";
               this.gxTv_Sdtempleados_Empleadosid_Z_SetNull( );
               this.gxTv_Sdtempleados_Empleadosareaid_Z_SetNull( );
               this.gxTv_Sdtempleados_Empleadosnomemple_Z_SetNull( );
               this.gxTv_Sdtempleados_Empleadosappaterno_Z_SetNull( );
               this.gxTv_Sdtempleados_Empleadosapmaterno_Z_SetNull( );
               this.gxTv_Sdtempleados_Empleadosstatus_Z_SetNull( );
               this.gxTv_Sdtempleados_Empleadosusuario_Z_SetNull( );
               this.gxTv_Sdtempleados_Empleadoscorreo_Z_SetNull( );
               this.gxTv_Sdtempleados_Empleadosext_Z_SetNull( );
               this.gxTv_Sdtempleados_Empleadosfecreg_Z_SetNull( );
               this.gxTv_Sdtempleados_Empleadosfecultact_Z_SetNull( );
            }
            gxTv_Sdtempleados_Empleadosid = (int)(value);
         }

      }

      [  SoapElement( ElementName = "empleadosareaid" )]
      [  XmlElement( ElementName = "empleadosareaid"   )]
      public String gxTpr_Empleadosareaid
      {
         get {
            return gxTv_Sdtempleados_Empleadosareaid ;
         }

         set {
            gxTv_Sdtempleados_Empleadosareaid_N = 0;
            gxTv_Sdtempleados_Empleadosareaid = (String)(value);
         }

      }

      public void gxTv_Sdtempleados_Empleadosareaid_SetNull( )
      {
         gxTv_Sdtempleados_Empleadosareaid_N = 1;
         gxTv_Sdtempleados_Empleadosareaid = "";
         return  ;
      }

      public bool gxTv_Sdtempleados_Empleadosareaid_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadosnomemple" )]
      [  XmlElement( ElementName = "empleadosnomemple"   )]
      public String gxTpr_Empleadosnomemple
      {
         get {
            return gxTv_Sdtempleados_Empleadosnomemple ;
         }

         set {
            gxTv_Sdtempleados_Empleadosnomemple_N = 0;
            gxTv_Sdtempleados_Empleadosnomemple = (String)(value);
         }

      }

      public void gxTv_Sdtempleados_Empleadosnomemple_SetNull( )
      {
         gxTv_Sdtempleados_Empleadosnomemple_N = 1;
         gxTv_Sdtempleados_Empleadosnomemple = "";
         return  ;
      }

      public bool gxTv_Sdtempleados_Empleadosnomemple_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadosappaterno" )]
      [  XmlElement( ElementName = "empleadosappaterno"   )]
      public String gxTpr_Empleadosappaterno
      {
         get {
            return gxTv_Sdtempleados_Empleadosappaterno ;
         }

         set {
            gxTv_Sdtempleados_Empleadosappaterno_N = 0;
            gxTv_Sdtempleados_Empleadosappaterno = (String)(value);
         }

      }

      public void gxTv_Sdtempleados_Empleadosappaterno_SetNull( )
      {
         gxTv_Sdtempleados_Empleadosappaterno_N = 1;
         gxTv_Sdtempleados_Empleadosappaterno = "";
         return  ;
      }

      public bool gxTv_Sdtempleados_Empleadosappaterno_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadosapmaterno" )]
      [  XmlElement( ElementName = "empleadosapmaterno"   )]
      public String gxTpr_Empleadosapmaterno
      {
         get {
            return gxTv_Sdtempleados_Empleadosapmaterno ;
         }

         set {
            gxTv_Sdtempleados_Empleadosapmaterno_N = 0;
            gxTv_Sdtempleados_Empleadosapmaterno = (String)(value);
         }

      }

      public void gxTv_Sdtempleados_Empleadosapmaterno_SetNull( )
      {
         gxTv_Sdtempleados_Empleadosapmaterno_N = 1;
         gxTv_Sdtempleados_Empleadosapmaterno = "";
         return  ;
      }

      public bool gxTv_Sdtempleados_Empleadosapmaterno_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadosstatus" )]
      [  XmlElement( ElementName = "empleadosstatus"   )]
      public String gxTpr_Empleadosstatus
      {
         get {
            return gxTv_Sdtempleados_Empleadosstatus ;
         }

         set {
            gxTv_Sdtempleados_Empleadosstatus_N = 0;
            gxTv_Sdtempleados_Empleadosstatus = (String)(value);
         }

      }

      public void gxTv_Sdtempleados_Empleadosstatus_SetNull( )
      {
         gxTv_Sdtempleados_Empleadosstatus_N = 1;
         gxTv_Sdtempleados_Empleadosstatus = "";
         return  ;
      }

      public bool gxTv_Sdtempleados_Empleadosstatus_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadosusuario" )]
      [  XmlElement( ElementName = "empleadosusuario"   )]
      public String gxTpr_Empleadosusuario
      {
         get {
            return gxTv_Sdtempleados_Empleadosusuario ;
         }

         set {
            gxTv_Sdtempleados_Empleadosusuario_N = 0;
            gxTv_Sdtempleados_Empleadosusuario = (String)(value);
         }

      }

      public void gxTv_Sdtempleados_Empleadosusuario_SetNull( )
      {
         gxTv_Sdtempleados_Empleadosusuario_N = 1;
         gxTv_Sdtempleados_Empleadosusuario = "";
         return  ;
      }

      public bool gxTv_Sdtempleados_Empleadosusuario_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadoscorreo" )]
      [  XmlElement( ElementName = "empleadoscorreo"   )]
      public String gxTpr_Empleadoscorreo
      {
         get {
            return gxTv_Sdtempleados_Empleadoscorreo ;
         }

         set {
            gxTv_Sdtempleados_Empleadoscorreo_N = 0;
            gxTv_Sdtempleados_Empleadoscorreo = (String)(value);
         }

      }

      public void gxTv_Sdtempleados_Empleadoscorreo_SetNull( )
      {
         gxTv_Sdtempleados_Empleadoscorreo_N = 1;
         gxTv_Sdtempleados_Empleadoscorreo = "";
         return  ;
      }

      public bool gxTv_Sdtempleados_Empleadoscorreo_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadosext" )]
      [  XmlElement( ElementName = "empleadosext"   )]
      public String gxTpr_Empleadosext
      {
         get {
            return gxTv_Sdtempleados_Empleadosext ;
         }

         set {
            gxTv_Sdtempleados_Empleadosext_N = 0;
            gxTv_Sdtempleados_Empleadosext = (String)(value);
         }

      }

      public void gxTv_Sdtempleados_Empleadosext_SetNull( )
      {
         gxTv_Sdtempleados_Empleadosext_N = 1;
         gxTv_Sdtempleados_Empleadosext = "";
         return  ;
      }

      public bool gxTv_Sdtempleados_Empleadosext_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadosfecreg" )]
      [  XmlElement( ElementName = "empleadosfecreg"  , IsNullable=true )]
      public string gxTpr_Empleadosfecreg_Nullable
      {
         get {
            if ( gxTv_Sdtempleados_Empleadosfecreg == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_Sdtempleados_Empleadosfecreg).value ;
         }

         set {
            gxTv_Sdtempleados_Empleadosfecreg_N = 0;
            if (value == null || value == GxDateString.NullValue )
               gxTv_Sdtempleados_Empleadosfecreg = DateTime.MinValue;
            else
               gxTv_Sdtempleados_Empleadosfecreg = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Empleadosfecreg
      {
         get {
            return gxTv_Sdtempleados_Empleadosfecreg ;
         }

         set {
            gxTv_Sdtempleados_Empleadosfecreg_N = 0;
            gxTv_Sdtempleados_Empleadosfecreg = (DateTime)(value);
         }

      }

      public void gxTv_Sdtempleados_Empleadosfecreg_SetNull( )
      {
         gxTv_Sdtempleados_Empleadosfecreg_N = 1;
         gxTv_Sdtempleados_Empleadosfecreg = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtempleados_Empleadosfecreg_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadosfecultact" )]
      [  XmlElement( ElementName = "empleadosfecultact"  , IsNullable=true )]
      public string gxTpr_Empleadosfecultact_Nullable
      {
         get {
            if ( gxTv_Sdtempleados_Empleadosfecultact == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_Sdtempleados_Empleadosfecultact).value ;
         }

         set {
            if (value == null || value == GxDateString.NullValue )
               gxTv_Sdtempleados_Empleadosfecultact = DateTime.MinValue;
            else
               gxTv_Sdtempleados_Empleadosfecultact = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Empleadosfecultact
      {
         get {
            return gxTv_Sdtempleados_Empleadosfecultact ;
         }

         set {
            gxTv_Sdtempleados_Empleadosfecultact = (DateTime)(value);
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_Sdtempleados_Mode ;
         }

         set {
            gxTv_Sdtempleados_Mode = (String)(value);
         }

      }

      public void gxTv_Sdtempleados_Mode_SetNull( )
      {
         gxTv_Sdtempleados_Mode = "";
         return  ;
      }

      public bool gxTv_Sdtempleados_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_Sdtempleados_Initialized ;
         }

         set {
            gxTv_Sdtempleados_Initialized = (short)(value);
         }

      }

      public void gxTv_Sdtempleados_Initialized_SetNull( )
      {
         gxTv_Sdtempleados_Initialized = 0;
         return  ;
      }

      public bool gxTv_Sdtempleados_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadosid_Z" )]
      [  XmlElement( ElementName = "empleadosid_Z"   )]
      public int gxTpr_Empleadosid_Z
      {
         get {
            return gxTv_Sdtempleados_Empleadosid_Z ;
         }

         set {
            gxTv_Sdtempleados_Empleadosid_Z = (int)(value);
         }

      }

      public void gxTv_Sdtempleados_Empleadosid_Z_SetNull( )
      {
         gxTv_Sdtempleados_Empleadosid_Z = 0;
         return  ;
      }

      public bool gxTv_Sdtempleados_Empleadosid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadosareaid_Z" )]
      [  XmlElement( ElementName = "empleadosareaid_Z"   )]
      public String gxTpr_Empleadosareaid_Z
      {
         get {
            return gxTv_Sdtempleados_Empleadosareaid_Z ;
         }

         set {
            gxTv_Sdtempleados_Empleadosareaid_Z = (String)(value);
         }

      }

      public void gxTv_Sdtempleados_Empleadosareaid_Z_SetNull( )
      {
         gxTv_Sdtempleados_Empleadosareaid_Z = "";
         return  ;
      }

      public bool gxTv_Sdtempleados_Empleadosareaid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadosnomemple_Z" )]
      [  XmlElement( ElementName = "empleadosnomemple_Z"   )]
      public String gxTpr_Empleadosnomemple_Z
      {
         get {
            return gxTv_Sdtempleados_Empleadosnomemple_Z ;
         }

         set {
            gxTv_Sdtempleados_Empleadosnomemple_Z = (String)(value);
         }

      }

      public void gxTv_Sdtempleados_Empleadosnomemple_Z_SetNull( )
      {
         gxTv_Sdtempleados_Empleadosnomemple_Z = "";
         return  ;
      }

      public bool gxTv_Sdtempleados_Empleadosnomemple_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadosappaterno_Z" )]
      [  XmlElement( ElementName = "empleadosappaterno_Z"   )]
      public String gxTpr_Empleadosappaterno_Z
      {
         get {
            return gxTv_Sdtempleados_Empleadosappaterno_Z ;
         }

         set {
            gxTv_Sdtempleados_Empleadosappaterno_Z = (String)(value);
         }

      }

      public void gxTv_Sdtempleados_Empleadosappaterno_Z_SetNull( )
      {
         gxTv_Sdtempleados_Empleadosappaterno_Z = "";
         return  ;
      }

      public bool gxTv_Sdtempleados_Empleadosappaterno_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadosapmaterno_Z" )]
      [  XmlElement( ElementName = "empleadosapmaterno_Z"   )]
      public String gxTpr_Empleadosapmaterno_Z
      {
         get {
            return gxTv_Sdtempleados_Empleadosapmaterno_Z ;
         }

         set {
            gxTv_Sdtempleados_Empleadosapmaterno_Z = (String)(value);
         }

      }

      public void gxTv_Sdtempleados_Empleadosapmaterno_Z_SetNull( )
      {
         gxTv_Sdtempleados_Empleadosapmaterno_Z = "";
         return  ;
      }

      public bool gxTv_Sdtempleados_Empleadosapmaterno_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadosstatus_Z" )]
      [  XmlElement( ElementName = "empleadosstatus_Z"   )]
      public String gxTpr_Empleadosstatus_Z
      {
         get {
            return gxTv_Sdtempleados_Empleadosstatus_Z ;
         }

         set {
            gxTv_Sdtempleados_Empleadosstatus_Z = (String)(value);
         }

      }

      public void gxTv_Sdtempleados_Empleadosstatus_Z_SetNull( )
      {
         gxTv_Sdtempleados_Empleadosstatus_Z = "";
         return  ;
      }

      public bool gxTv_Sdtempleados_Empleadosstatus_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadosusuario_Z" )]
      [  XmlElement( ElementName = "empleadosusuario_Z"   )]
      public String gxTpr_Empleadosusuario_Z
      {
         get {
            return gxTv_Sdtempleados_Empleadosusuario_Z ;
         }

         set {
            gxTv_Sdtempleados_Empleadosusuario_Z = (String)(value);
         }

      }

      public void gxTv_Sdtempleados_Empleadosusuario_Z_SetNull( )
      {
         gxTv_Sdtempleados_Empleadosusuario_Z = "";
         return  ;
      }

      public bool gxTv_Sdtempleados_Empleadosusuario_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadoscorreo_Z" )]
      [  XmlElement( ElementName = "empleadoscorreo_Z"   )]
      public String gxTpr_Empleadoscorreo_Z
      {
         get {
            return gxTv_Sdtempleados_Empleadoscorreo_Z ;
         }

         set {
            gxTv_Sdtempleados_Empleadoscorreo_Z = (String)(value);
         }

      }

      public void gxTv_Sdtempleados_Empleadoscorreo_Z_SetNull( )
      {
         gxTv_Sdtempleados_Empleadoscorreo_Z = "";
         return  ;
      }

      public bool gxTv_Sdtempleados_Empleadoscorreo_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadosext_Z" )]
      [  XmlElement( ElementName = "empleadosext_Z"   )]
      public String gxTpr_Empleadosext_Z
      {
         get {
            return gxTv_Sdtempleados_Empleadosext_Z ;
         }

         set {
            gxTv_Sdtempleados_Empleadosext_Z = (String)(value);
         }

      }

      public void gxTv_Sdtempleados_Empleadosext_Z_SetNull( )
      {
         gxTv_Sdtempleados_Empleadosext_Z = "";
         return  ;
      }

      public bool gxTv_Sdtempleados_Empleadosext_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadosfecreg_Z" )]
      [  XmlElement( ElementName = "empleadosfecreg_Z"  , IsNullable=true )]
      public string gxTpr_Empleadosfecreg_Z_Nullable
      {
         get {
            if ( gxTv_Sdtempleados_Empleadosfecreg_Z == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_Sdtempleados_Empleadosfecreg_Z).value ;
         }

         set {
            if (value == null || value == GxDateString.NullValue )
               gxTv_Sdtempleados_Empleadosfecreg_Z = DateTime.MinValue;
            else
               gxTv_Sdtempleados_Empleadosfecreg_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Empleadosfecreg_Z
      {
         get {
            return gxTv_Sdtempleados_Empleadosfecreg_Z ;
         }

         set {
            gxTv_Sdtempleados_Empleadosfecreg_Z = (DateTime)(value);
         }

      }

      public void gxTv_Sdtempleados_Empleadosfecreg_Z_SetNull( )
      {
         gxTv_Sdtempleados_Empleadosfecreg_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtempleados_Empleadosfecreg_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadosfecultact_Z" )]
      [  XmlElement( ElementName = "empleadosfecultact_Z"  , IsNullable=true )]
      public string gxTpr_Empleadosfecultact_Z_Nullable
      {
         get {
            if ( gxTv_Sdtempleados_Empleadosfecultact_Z == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_Sdtempleados_Empleadosfecultact_Z).value ;
         }

         set {
            if (value == null || value == GxDateString.NullValue )
               gxTv_Sdtempleados_Empleadosfecultact_Z = DateTime.MinValue;
            else
               gxTv_Sdtempleados_Empleadosfecultact_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Empleadosfecultact_Z
      {
         get {
            return gxTv_Sdtempleados_Empleadosfecultact_Z ;
         }

         set {
            gxTv_Sdtempleados_Empleadosfecultact_Z = (DateTime)(value);
         }

      }

      public void gxTv_Sdtempleados_Empleadosfecultact_Z_SetNull( )
      {
         gxTv_Sdtempleados_Empleadosfecultact_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_Sdtempleados_Empleadosfecultact_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadosid_N" )]
      [  XmlElement( ElementName = "empleadosid_N"   )]
      public short gxTpr_Empleadosid_N
      {
         get {
            return gxTv_Sdtempleados_Empleadosid_N ;
         }

         set {
            gxTv_Sdtempleados_Empleadosid_N = (short)(value);
         }

      }

      public void gxTv_Sdtempleados_Empleadosid_N_SetNull( )
      {
         gxTv_Sdtempleados_Empleadosid_N = 0;
         return  ;
      }

      public bool gxTv_Sdtempleados_Empleadosid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadosareaid_N" )]
      [  XmlElement( ElementName = "empleadosareaid_N"   )]
      public short gxTpr_Empleadosareaid_N
      {
         get {
            return gxTv_Sdtempleados_Empleadosareaid_N ;
         }

         set {
            gxTv_Sdtempleados_Empleadosareaid_N = (short)(value);
         }

      }

      public void gxTv_Sdtempleados_Empleadosareaid_N_SetNull( )
      {
         gxTv_Sdtempleados_Empleadosareaid_N = 0;
         return  ;
      }

      public bool gxTv_Sdtempleados_Empleadosareaid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadosnomemple_N" )]
      [  XmlElement( ElementName = "empleadosnomemple_N"   )]
      public short gxTpr_Empleadosnomemple_N
      {
         get {
            return gxTv_Sdtempleados_Empleadosnomemple_N ;
         }

         set {
            gxTv_Sdtempleados_Empleadosnomemple_N = (short)(value);
         }

      }

      public void gxTv_Sdtempleados_Empleadosnomemple_N_SetNull( )
      {
         gxTv_Sdtempleados_Empleadosnomemple_N = 0;
         return  ;
      }

      public bool gxTv_Sdtempleados_Empleadosnomemple_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadosappaterno_N" )]
      [  XmlElement( ElementName = "empleadosappaterno_N"   )]
      public short gxTpr_Empleadosappaterno_N
      {
         get {
            return gxTv_Sdtempleados_Empleadosappaterno_N ;
         }

         set {
            gxTv_Sdtempleados_Empleadosappaterno_N = (short)(value);
         }

      }

      public void gxTv_Sdtempleados_Empleadosappaterno_N_SetNull( )
      {
         gxTv_Sdtempleados_Empleadosappaterno_N = 0;
         return  ;
      }

      public bool gxTv_Sdtempleados_Empleadosappaterno_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadosapmaterno_N" )]
      [  XmlElement( ElementName = "empleadosapmaterno_N"   )]
      public short gxTpr_Empleadosapmaterno_N
      {
         get {
            return gxTv_Sdtempleados_Empleadosapmaterno_N ;
         }

         set {
            gxTv_Sdtempleados_Empleadosapmaterno_N = (short)(value);
         }

      }

      public void gxTv_Sdtempleados_Empleadosapmaterno_N_SetNull( )
      {
         gxTv_Sdtempleados_Empleadosapmaterno_N = 0;
         return  ;
      }

      public bool gxTv_Sdtempleados_Empleadosapmaterno_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadosstatus_N" )]
      [  XmlElement( ElementName = "empleadosstatus_N"   )]
      public short gxTpr_Empleadosstatus_N
      {
         get {
            return gxTv_Sdtempleados_Empleadosstatus_N ;
         }

         set {
            gxTv_Sdtempleados_Empleadosstatus_N = (short)(value);
         }

      }

      public void gxTv_Sdtempleados_Empleadosstatus_N_SetNull( )
      {
         gxTv_Sdtempleados_Empleadosstatus_N = 0;
         return  ;
      }

      public bool gxTv_Sdtempleados_Empleadosstatus_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadosusuario_N" )]
      [  XmlElement( ElementName = "empleadosusuario_N"   )]
      public short gxTpr_Empleadosusuario_N
      {
         get {
            return gxTv_Sdtempleados_Empleadosusuario_N ;
         }

         set {
            gxTv_Sdtempleados_Empleadosusuario_N = (short)(value);
         }

      }

      public void gxTv_Sdtempleados_Empleadosusuario_N_SetNull( )
      {
         gxTv_Sdtempleados_Empleadosusuario_N = 0;
         return  ;
      }

      public bool gxTv_Sdtempleados_Empleadosusuario_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadoscorreo_N" )]
      [  XmlElement( ElementName = "empleadoscorreo_N"   )]
      public short gxTpr_Empleadoscorreo_N
      {
         get {
            return gxTv_Sdtempleados_Empleadoscorreo_N ;
         }

         set {
            gxTv_Sdtempleados_Empleadoscorreo_N = (short)(value);
         }

      }

      public void gxTv_Sdtempleados_Empleadoscorreo_N_SetNull( )
      {
         gxTv_Sdtempleados_Empleadoscorreo_N = 0;
         return  ;
      }

      public bool gxTv_Sdtempleados_Empleadoscorreo_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadosext_N" )]
      [  XmlElement( ElementName = "empleadosext_N"   )]
      public short gxTpr_Empleadosext_N
      {
         get {
            return gxTv_Sdtempleados_Empleadosext_N ;
         }

         set {
            gxTv_Sdtempleados_Empleadosext_N = (short)(value);
         }

      }

      public void gxTv_Sdtempleados_Empleadosext_N_SetNull( )
      {
         gxTv_Sdtempleados_Empleadosext_N = 0;
         return  ;
      }

      public bool gxTv_Sdtempleados_Empleadosext_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "empleadosfecreg_N" )]
      [  XmlElement( ElementName = "empleadosfecreg_N"   )]
      public short gxTpr_Empleadosfecreg_N
      {
         get {
            return gxTv_Sdtempleados_Empleadosfecreg_N ;
         }

         set {
            gxTv_Sdtempleados_Empleadosfecreg_N = (short)(value);
         }

      }

      public void gxTv_Sdtempleados_Empleadosfecreg_N_SetNull( )
      {
         gxTv_Sdtempleados_Empleadosfecreg_N = 0;
         return  ;
      }

      public bool gxTv_Sdtempleados_Empleadosfecreg_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_Sdtempleados_Empleadosareaid = "";
         gxTv_Sdtempleados_Empleadosnomemple = "";
         gxTv_Sdtempleados_Empleadosappaterno = "";
         gxTv_Sdtempleados_Empleadosapmaterno = "";
         gxTv_Sdtempleados_Empleadosstatus = "";
         gxTv_Sdtempleados_Empleadosusuario = "";
         gxTv_Sdtempleados_Empleadoscorreo = "";
         gxTv_Sdtempleados_Empleadosext = "";
         gxTv_Sdtempleados_Empleadosfecreg = DateTime.MinValue;
         gxTv_Sdtempleados_Empleadosfecultact = DateTime.MinValue;
         gxTv_Sdtempleados_Mode = "";
         gxTv_Sdtempleados_Empleadosareaid_Z = "";
         gxTv_Sdtempleados_Empleadosnomemple_Z = "";
         gxTv_Sdtempleados_Empleadosappaterno_Z = "";
         gxTv_Sdtempleados_Empleadosapmaterno_Z = "";
         gxTv_Sdtempleados_Empleadosstatus_Z = "";
         gxTv_Sdtempleados_Empleadosusuario_Z = "";
         gxTv_Sdtempleados_Empleadoscorreo_Z = "";
         gxTv_Sdtempleados_Empleadosext_Z = "";
         gxTv_Sdtempleados_Empleadosfecreg_Z = DateTime.MinValue;
         gxTv_Sdtempleados_Empleadosfecultact_Z = DateTime.MinValue;
         sTagName = "";
         sDateCnv = "";
         sNumToPad = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "empleados", "GeneXus.Programs.empleados_bc", new Object[] {context}, constructorCallingAssembly);
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_Sdtempleados_Initialized ;
      private short gxTv_Sdtempleados_Empleadosid_N ;
      private short gxTv_Sdtempleados_Empleadosareaid_N ;
      private short gxTv_Sdtempleados_Empleadosnomemple_N ;
      private short gxTv_Sdtempleados_Empleadosappaterno_N ;
      private short gxTv_Sdtempleados_Empleadosapmaterno_N ;
      private short gxTv_Sdtempleados_Empleadosstatus_N ;
      private short gxTv_Sdtempleados_Empleadosusuario_N ;
      private short gxTv_Sdtempleados_Empleadoscorreo_N ;
      private short gxTv_Sdtempleados_Empleadosext_N ;
      private short gxTv_Sdtempleados_Empleadosfecreg_N ;
      private short readOk ;
      private short nOutParmCount ;
      private int gxTv_Sdtempleados_Empleadosid ;
      private int gxTv_Sdtempleados_Empleadosid_Z ;
      private String gxTv_Sdtempleados_Mode ;
      private String sTagName ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_Sdtempleados_Empleadosfecreg ;
      private DateTime gxTv_Sdtempleados_Empleadosfecultact ;
      private DateTime gxTv_Sdtempleados_Empleadosfecreg_Z ;
      private DateTime gxTv_Sdtempleados_Empleadosfecultact_Z ;
      private String gxTv_Sdtempleados_Empleadosareaid ;
      private String gxTv_Sdtempleados_Empleadosnomemple ;
      private String gxTv_Sdtempleados_Empleadosappaterno ;
      private String gxTv_Sdtempleados_Empleadosapmaterno ;
      private String gxTv_Sdtempleados_Empleadosstatus ;
      private String gxTv_Sdtempleados_Empleadosusuario ;
      private String gxTv_Sdtempleados_Empleadoscorreo ;
      private String gxTv_Sdtempleados_Empleadosext ;
      private String gxTv_Sdtempleados_Empleadosareaid_Z ;
      private String gxTv_Sdtempleados_Empleadosnomemple_Z ;
      private String gxTv_Sdtempleados_Empleadosappaterno_Z ;
      private String gxTv_Sdtempleados_Empleadosapmaterno_Z ;
      private String gxTv_Sdtempleados_Empleadosstatus_Z ;
      private String gxTv_Sdtempleados_Empleadosusuario_Z ;
      private String gxTv_Sdtempleados_Empleadoscorreo_Z ;
      private String gxTv_Sdtempleados_Empleadosext_Z ;
      private Assembly constructorCallingAssembly ;
   }

   [DataContract(Name = @"empleados", Namespace = "Condufef_v1")]
   public class Sdtempleados_RESTInterface : GxGenericCollectionItem<Sdtempleados>, System.Web.SessionState.IRequiresSessionState
   {
      public Sdtempleados_RESTInterface( ) : base()
      {
      }

      public Sdtempleados_RESTInterface( Sdtempleados psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "empleadosid" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Empleadosid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Empleadosid), 9, 0)) ;
         }

         set {
            sdt.gxTpr_Empleadosid = (int)(NumberUtil.Val( (String)(value), "."));
         }

      }

      [DataMember( Name = "empleadosareaid" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Empleadosareaid
      {
         get {
            return sdt.gxTpr_Empleadosareaid ;
         }

         set {
            sdt.gxTpr_Empleadosareaid = (String)(value);
         }

      }

      [DataMember( Name = "empleadosnomemple" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Empleadosnomemple
      {
         get {
            return sdt.gxTpr_Empleadosnomemple ;
         }

         set {
            sdt.gxTpr_Empleadosnomemple = (String)(value);
         }

      }

      [DataMember( Name = "empleadosappaterno" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Empleadosappaterno
      {
         get {
            return sdt.gxTpr_Empleadosappaterno ;
         }

         set {
            sdt.gxTpr_Empleadosappaterno = (String)(value);
         }

      }

      [DataMember( Name = "empleadosapmaterno" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Empleadosapmaterno
      {
         get {
            return sdt.gxTpr_Empleadosapmaterno ;
         }

         set {
            sdt.gxTpr_Empleadosapmaterno = (String)(value);
         }

      }

      [DataMember( Name = "empleadosstatus" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Empleadosstatus
      {
         get {
            return sdt.gxTpr_Empleadosstatus ;
         }

         set {
            sdt.gxTpr_Empleadosstatus = (String)(value);
         }

      }

      [DataMember( Name = "empleadosusuario" , Order = 6 )]
      [GxSeudo()]
      public String gxTpr_Empleadosusuario
      {
         get {
            return sdt.gxTpr_Empleadosusuario ;
         }

         set {
            sdt.gxTpr_Empleadosusuario = (String)(value);
         }

      }

      [DataMember( Name = "empleadoscorreo" , Order = 7 )]
      [GxSeudo()]
      public String gxTpr_Empleadoscorreo
      {
         get {
            return sdt.gxTpr_Empleadoscorreo ;
         }

         set {
            sdt.gxTpr_Empleadoscorreo = (String)(value);
         }

      }

      [DataMember( Name = "empleadosext" , Order = 8 )]
      [GxSeudo()]
      public String gxTpr_Empleadosext
      {
         get {
            return sdt.gxTpr_Empleadosext ;
         }

         set {
            sdt.gxTpr_Empleadosext = (String)(value);
         }

      }

      [DataMember( Name = "empleadosfecreg" , Order = 9 )]
      [GxSeudo()]
      public String gxTpr_Empleadosfecreg
      {
         get {
            return DateTimeUtil.DToC2( sdt.gxTpr_Empleadosfecreg) ;
         }

         set {
            sdt.gxTpr_Empleadosfecreg = DateTimeUtil.CToD2( (String)(value));
         }

      }

      [DataMember( Name = "empleadosfecultact" , Order = 10 )]
      [GxSeudo()]
      public String gxTpr_Empleadosfecultact
      {
         get {
            return DateTimeUtil.DToC2( sdt.gxTpr_Empleadosfecultact) ;
         }

         set {
            sdt.gxTpr_Empleadosfecultact = DateTimeUtil.CToD2( (String)(value));
         }

      }

      public Sdtempleados sdt
      {
         get {
            return (Sdtempleados)Sdt ;
         }

         set {
            Sdt = value ;
         }

      }

      [OnDeserializing]
      void checkSdt( StreamingContext ctx )
      {
         if ( sdt == null )
         {
            sdt = new Sdtempleados() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 34 )]
      public string Hash
      {
         get {
            if ( StringUtil.StrCmp(md5Hash, null) == 0 )
            {
               md5Hash = (String)(getHash());
            }
            return md5Hash ;
         }

         set {
            md5Hash = value ;
         }

      }

      private String md5Hash ;
   }

}
