﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proje_Hastane.Properties {
    using System;
    
    
    /// <summary>
    ///   Yerelleştirilmiş dizeleri aramak gibi işlemler için, türü kesin olarak belirtilmiş kaynak sınıfı.
    /// </summary>
    // Bu sınıf ResGen veya Visual Studio gibi bir araç kullanılarak StronglyTypedResourceBuilder
    // sınıfı tarafından otomatik olarak oluşturuldu.
    // Üye eklemek veya kaldırmak için .ResX dosyanızı düzenleyin ve sonra da ResGen
    // komutunu /str seçeneğiyle yeniden çalıştırın veya VS projenizi yeniden oluşturun.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Bu sınıf tarafından kullanılan, önbelleğe alınmış ResourceManager örneğini döndürür.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Proje_Hastane.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Tümü için geçerli iş parçacığının CurrentUICulture özelliğini geçersiz kular
        ///   CurrentUICulture özelliğini tüm kaynak aramaları için geçersiz kılar.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.
        /// </summary>
        internal static System.Drawing.Bitmap doktor_icon {
            get {
                object obj = ResourceManager.GetObject("doktor icon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.
        /// </summary>
        internal static System.Drawing.Bitmap hasta_icon {
            get {
                object obj = ResourceManager.GetObject("hasta icon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.
        /// </summary>
        internal static System.Drawing.Bitmap kalp_atışı {
            get {
                object obj = ResourceManager.GetObject("kalp atışı", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   System.Drawing.Bitmap türünde yerelleştirilmiş bir kaynak arar.
        /// </summary>
        internal static System.Drawing.Bitmap sekreter_icon {
            get {
                object obj = ResourceManager.GetObject("sekreter icon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}