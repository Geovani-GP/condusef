/*
               File: Effect
        Description: Effect
             Author: GeneXus C# Generator version 10_3_15-115824
       Generated on: 1/23/2022 3:49:51.49
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
using GeneXus.Data;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class gxdomaineffect
   {
      private static Hashtable domain = new Hashtable();
      static gxdomaineffect ()
      {
         domain["gx_default"] = "Default";
         domain["gx_curl_up"] = "Curl Up (iOS Only)";
         domain["gx_curl_down"] = "Curl Down (iOS Only)";
         domain["gx_flip_from_left"] = "Flip From Left (iOS only)";
         domain["gx_flip_from_right"] = "Flip From Right (iOS only)";
         domain["gx_slide_down"] = "Slide Down";
         domain["gx_slide_up"] = "Slide Up";
         domain["gx_slide_left"] = "Slide Left";
         domain["gx_slide_right"] = "Slide Right";
         domain["gx_push_down"] = "Push Down";
         domain["gx_push_up"] = "Push Up";
         domain["gx_push_left"] = "Push Left";
         domain["gx_push_right"] = "Push Right";
         domain["gx_fade"] = "Fade";
         domain["gx_none"] = "None";
      }

      public static string getDescription( IGxContext context ,
                                           String key )
      {
         string rtkey ;
         rtkey = StringUtil.Trim( (String)(key));
         return (string)domain[rtkey] ;
      }

      public static GxSimpleCollection getValues( )
      {
         GxSimpleCollection value = new GxSimpleCollection();
         ArrayList aKeys = new ArrayList(domain.Keys);
         aKeys.Sort();
         foreach (String key in aKeys)
         {
            value.Add(key);
         }
         return value;
      }

   }

}
