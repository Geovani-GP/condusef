/*
               File: type_SdtSchedulerEvents_Day
        Description: SchedulerEvents
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/26/2022 20:8:21.93
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
using GeneXus.Data;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
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
   [XmlRoot(ElementName = "SchedulerEvents.Day" )]
   [XmlType(TypeName =  "SchedulerEvents.Day" , Namespace = "" )]
   [Serializable]
   public class SdtSchedulerEvents_Day : GxUserType
   {
      public SdtSchedulerEvents_Day( )
      {
         /* Constructor for serialization */
         gxTv_SdtSchedulerEvents_Day_Date = DateTime.MinValue;
         gxTv_SdtSchedulerEvents_Day_Color = "";
      }

      public SdtSchedulerEvents_Day( IGxContext context )
      {
         this.context = context;
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

      public override String ToXml( bool includeHeader ,
                                    bool includeState ,
                                    String name ,
                                    String sNameSpace )
      {
         String s ;
         XmlSerializer xmls ;
         xmls = new XmlSerializer(this.GetType(), sNameSpace);
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
         SdtSchedulerEvents_Day deserialized ;
         if (s.Trim().Length == 0)
            return;
         XmlSerializer xmls = new XmlSerializer(this.GetType());
         System.IO.StringReader sr = new System.IO.StringReader(s);
         deserialized = (SdtSchedulerEvents_Day)(xmls.Deserialize( sr)) ;
         sr.Close();
         SdtSchedulerEvents_Day obj ;
         obj = this;
         obj.gxTpr_Date = deserialized.gxTpr_Date;
         obj.gxTpr_Color = deserialized.gxTpr_Color;
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
               if ( StringUtil.StrCmp2( oReader.LocalName, "Date") && ( oReader.NodeType != 2 ) && ( StringUtil.StrCmp(oReader.NamespaceURI, "") == 0 ) )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_SdtSchedulerEvents_Day_Date = DateTime.MinValue;
                  }
                  else
                  {
                     gxTv_SdtSchedulerEvents_Day_Date = context.localUtil.YMDToD( (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (int)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")));
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1;
                  }
                  GXSoapError = oReader.Read();
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Color") && ( oReader.NodeType != 2 ) && ( StringUtil.StrCmp(oReader.NamespaceURI, "") == 0 ) )
               {
                  gxTv_SdtSchedulerEvents_Day_Color = oReader.Value;
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
            sName = "SchedulerEvents.Day";
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
         if ( (DateTime.MinValue==gxTv_SdtSchedulerEvents_Day_Date) )
         {
            oWriter.WriteStartElement("Date");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtSchedulerEvents_Day_Date)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtSchedulerEvents_Day_Date)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtSchedulerEvents_Day_Date)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            oWriter.WriteElement("Date", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "");
            }
         }
         oWriter.WriteElement("Color", StringUtil.RTrim( gxTv_SdtSchedulerEvents_Day_Color));
         if ( StringUtil.StrCmp(sNameSpace, "") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "");
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
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtSchedulerEvents_Day_Date)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtSchedulerEvents_Day_Date)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtSchedulerEvents_Day_Date)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("Date", sDateCnv, false);
         AddObjectProperty("Color", gxTv_SdtSchedulerEvents_Day_Color, false);
         return  ;
      }

      [  SoapElement( ElementName = "Date" )]
      [  XmlElement( ElementName = "Date"  , IsNullable=true )]
      public string gxTpr_Date_Nullable
      {
         get {
            if ( gxTv_SdtSchedulerEvents_Day_Date == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtSchedulerEvents_Day_Date).value ;
         }

         set {
            if (value == null || value == GxDateString.NullValue )
               gxTv_SdtSchedulerEvents_Day_Date = DateTime.MinValue;
            else
               gxTv_SdtSchedulerEvents_Day_Date = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Date
      {
         get {
            return gxTv_SdtSchedulerEvents_Day_Date ;
         }

         set {
            gxTv_SdtSchedulerEvents_Day_Date = (DateTime)(value);
         }

      }

      [  SoapElement( ElementName = "Color" )]
      [  XmlElement( ElementName = "Color"   )]
      public String gxTpr_Color
      {
         get {
            return gxTv_SdtSchedulerEvents_Day_Color ;
         }

         set {
            gxTv_SdtSchedulerEvents_Day_Color = (String)(value);
         }

      }

      public void initialize( )
      {
         gxTv_SdtSchedulerEvents_Day_Date = DateTime.MinValue;
         gxTv_SdtSchedulerEvents_Day_Color = "";
         sTagName = "";
         sDateCnv = "";
         sNumToPad = "";
         return  ;
      }

      protected short readOk ;
      protected short nOutParmCount ;
      protected String gxTv_SdtSchedulerEvents_Day_Color ;
      protected String sTagName ;
      protected String sDateCnv ;
      protected String sNumToPad ;
      protected DateTime gxTv_SdtSchedulerEvents_Day_Date ;
   }

   [DataContract(Name = @"SchedulerEvents.Day", Namespace = "")]
   public class SdtSchedulerEvents_Day_RESTInterface : GxGenericCollectionItem<SdtSchedulerEvents_Day>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSchedulerEvents_Day_RESTInterface( ) : base()
      {
      }

      public SdtSchedulerEvents_Day_RESTInterface( SdtSchedulerEvents_Day psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "Date" , Order = 0 )]
      public String gxTpr_Date
      {
         get {
            return DateTimeUtil.DToC2( sdt.gxTpr_Date) ;
         }

         set {
            sdt.gxTpr_Date = DateTimeUtil.CToD2( (String)(value));
         }

      }

      [DataMember( Name = "Color" , Order = 1 )]
      public String gxTpr_Color
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Color) ;
         }

         set {
            sdt.gxTpr_Color = (String)(value);
         }

      }

      public SdtSchedulerEvents_Day sdt
      {
         get {
            return (SdtSchedulerEvents_Day)Sdt ;
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
            sdt = new SdtSchedulerEvents_Day() ;
         }
      }

   }

}
