// This code was generated using jni4net. See http://jni4net.sourceforge.net/

#region Component Designer generated code
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantCast
// ReSharper disable RedundantCommaInArrayInitializer
// ReSharper disable RedundantExplicitArrayCreation
// ReSharper disable UnassignedField.Local
// ReSharper disable UnusedMember.Local
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantExtendsListEntry
// ReSharper disable SuggestUseVarKeywordEvident
// ReSharper disable PossibleMultipleEnumeration
// ReSharper disable MemberHidesStaticFromOuterClass
// ReSharper disable UnusedParameter.Local
// ReSharper disable UnusedMember.Global
#pragma warning disable 109
#pragma warning disable 649
#pragma warning disable 618

namespace java.lang.annotation
{
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.annotation.Annotation_))]
    public partial interface Annotation
    {
        /// <signature>#0 ()Ljava/lang/Class; ()Ljava/lang/Class;</signature>
        global::java.lang.Class annotationType();
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.annotation.Annotation_))]
    static public partial class Annotation_
    {
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_TypeInfo;
        
        static internal global::java.lang.IClass j4n_Class;
        
        static internal global::System.IntPtr[] j4n_Members = global::net.sf.jni4net.core.Registry.dummyMethods;
        
        static public global::java.lang.IClass _class {
            get {
                return j4n_Class;
            }
        }
        
        static Annotation_()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.annotation.Annotation_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(java.lang.annotation.Annotation_));
        }
        
        /// <signature>#0 annotationType()Ljava/lang/Class; ()Ljava/lang/Class;</signature>
        static global::System.IntPtr j4n_0(global::System.IntPtr j4n_penv, global::System.IntPtr j4n_self)
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = new global::net.sf.jni4net.jni.JNIEnv(j4n_penv);
            global::net.sf.jni4net.jni.LocalFrame j4n_frame = new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10);
            try
            {
                java.lang.annotation.Annotation j4n_real = global::net.sf.jni4net.core.ConvertAbstract.ToCLR<java.lang.annotation.Annotation>(j4n_env, j4n_self);
                j4n_frame.Result = global::net.sf.jni4net.core.ConvertAbstract.ToPtr(j4n_env, j4n_real.annotationType(), "java.lang.Class");
            }
            catch (global::System.Exception j4n_ex)
            {
                j4n_env.ThrowExisting(j4n_ex);
                return default(global::System.IntPtr);
            }
            finally{
                j4n_frame.Dispose();
            }
            return j4n_frame.Result;
        }
        
        static internal global::net.sf.jni4net.core.ProxyInfo j4n_ProxyInit(global::net.sf.jni4net.core.ProxyInfo proxyInfo)
        {
            lock (typeof(global::java.lang.annotation.Annotation))
            {
                if (j4n_TypeInfo==null)
                {
                    j4n_TypeInfo = proxyInfo;
                    proxyInfo.IsCLR = false;
                    proxyInfo.IsInterface = true;
                    proxyInfo.JVMApiName = "java.lang.annotation.Annotation";
                    proxyInfo.JVMProxyName = "java_.lang.annotation._Annotation";
                    proxyInfo.JVMStaticApiName = "java_.lang.annotation.Annotation_";
                    proxyInfo.CLRApi = typeof(java.lang.annotation.Annotation);
                    proxyInfo.CLRStaticApi = typeof(java.lang.annotation.Annotation_);
                    proxyInfo.CLRProxy = typeof(java.lang.annotation._Annotation);
                    proxyInfo.JVMProxyFactory = java.lang.annotation._Annotation.j4n_ProxyFactory;
                    proxyInfo.MemberIds = new global::net.sf.jni4net.core.MemberId[]{
                        new global::net.sf.jni4net.core.MemberId("annotationType","()Ljava/lang/Class;", false, false), // #0 ()Ljava/lang/Class;
                        };
                }
                return j4n_TypeInfo;
            }
        }
    }
    
    [global::net.sf.jni4net.attributes.J4NProxy(typeof(java.lang.annotation.Annotation_))]
    internal partial class _Annotation : global::java.lang.Object, java.lang.annotation.Annotation
    {
        static _Annotation()
        {
            global::net.sf.jni4net.modules.jremicroj4n.InitModule();
            global::net.sf.jni4net.core.Registry.InitJvmProxy(typeof(java.lang.annotation.Annotation_));
            global::net.sf.jni4net.core.Registry.InitClrProxy(typeof(java.lang.annotation.Annotation_));
        }
        
        protected _Annotation(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::net.sf.jni4net.jni.JNIHandle j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
            : base(j4n_env, j4n_handle, j4n_instanceInfo)
        {
        }
        
        static internal global::net.sf.jni4net.IJvmProxy j4n_ProxyFactory(global::net.sf.jni4net.jni.JNIEnv j4n_env, global::System.IntPtr j4n_handle, global::net.sf.jni4net.core.JvmInstanceInfo j4n_instanceInfo)
        {
            return new java.lang.annotation._Annotation(j4n_env, j4n_env.NewGlobalRef(j4n_handle), j4n_instanceInfo);
        }
        
        /// <signature>#0 ()Ljava/lang/Class; ()Ljava/lang/Class;</signature>
        public global::java.lang.Class annotationType()
        {
            global::net.sf.jni4net.jni.JNIEnv j4n_env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(j4n_env, 10))
            {
                return global::net.sf.jni4net.core.ConvertClass.ToCLR<global::java.lang.Class>(j4n_env, j4n_env.CallObjectMethod(this, java.lang.annotation.Annotation_.j4n_Members[0]));
            }
        }
    }
}

#endregion Component Designer generated code