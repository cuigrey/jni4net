//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class Integer : global::java.lang.Number, global::java.lang.Comparable {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _compareTo0;
        
        internal static global::net.sf.jni4net.jni.MethodId _compareTo1;
        
        internal static global::net.sf.jni4net.jni.MethodId _toHexString2;
        
        internal static global::net.sf.jni4net.jni.MethodId _toString3;
        
        internal static global::net.sf.jni4net.jni.MethodId _toString4;
        
        internal static global::net.sf.jni4net.jni.MethodId _decode5;
        
        internal static global::net.sf.jni4net.jni.MethodId _valueOf6;
        
        internal static global::net.sf.jni4net.jni.MethodId _valueOf7;
        
        internal static global::net.sf.jni4net.jni.MethodId _valueOf8;
        
        internal static global::net.sf.jni4net.jni.MethodId _reverse9;
        
        internal static global::net.sf.jni4net.jni.MethodId _reverseBytes10;
        
        internal static global::net.sf.jni4net.jni.MethodId _parseInt11;
        
        internal static global::net.sf.jni4net.jni.MethodId _parseInt12;
        
        internal static global::net.sf.jni4net.jni.MethodId _bitCount13;
        
        internal static global::net.sf.jni4net.jni.MethodId _getInteger14;
        
        internal static global::net.sf.jni4net.jni.MethodId _getInteger15;
        
        internal static global::net.sf.jni4net.jni.MethodId _getInteger16;
        
        internal static global::net.sf.jni4net.jni.MethodId _highestOneBit17;
        
        internal static global::net.sf.jni4net.jni.MethodId _lowestOneBit18;
        
        internal static global::net.sf.jni4net.jni.MethodId _numberOfLeadingZeros19;
        
        internal static global::net.sf.jni4net.jni.MethodId _numberOfTrailingZeros20;
        
        internal static global::net.sf.jni4net.jni.MethodId _rotateLeft21;
        
        internal static global::net.sf.jni4net.jni.MethodId _rotateRight22;
        
        internal static global::net.sf.jni4net.jni.MethodId _signum23;
        
        internal static global::net.sf.jni4net.jni.MethodId _toBinaryString24;
        
        internal static global::net.sf.jni4net.jni.MethodId _toOctalString25;
        
        internal static global::net.sf.jni4net.jni.FieldId _MIN_VALUE26;
        
        internal static global::net.sf.jni4net.jni.FieldId _MAX_VALUE27;
        
        internal static global::net.sf.jni4net.jni.FieldId _TYPE28;
        
        internal static global::net.sf.jni4net.jni.FieldId _SIZE29;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor30;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor31;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)V")]
        public Integer(int par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            env.NewObject(global::java.lang.Integer.staticClass, global::java.lang.Integer.@__ctor30, this, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public Integer(global::java.lang.String par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            env.NewObject(global::java.lang.Integer.staticClass, global::java.lang.Integer.@__ctor31, this, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        protected Integer(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.Integer.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int MIN_VALUE {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return env.GetStaticIntField(global::java.lang.Integer.staticClass, global::java.lang.Integer._MIN_VALUE26);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int MAX_VALUE {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return env.GetStaticIntField(global::java.lang.Integer.staticClass, global::java.lang.Integer._MAX_VALUE27);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Ljava/lang/Class;")]
        public static global::java.lang.Class TYPE {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Class>(env.GetStaticObjectField(global::java.lang.Integer.staticClass, global::java.lang.Integer._TYPE28));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int SIZE {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return env.GetStaticIntField(global::java.lang.Integer.staticClass, global::java.lang.Integer._SIZE29);
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::java.lang.Integer.staticClass = staticClass;
            global::java.lang.Integer._compareTo0 = env.GetMethodID(global::java.lang.Integer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
            global::java.lang.Integer._compareTo1 = env.GetMethodID(global::java.lang.Integer.staticClass, "compareTo", "(Ljava/lang/Integer;)I");
            global::java.lang.Integer._toHexString2 = env.GetStaticMethodID(global::java.lang.Integer.staticClass, "toHexString", "(I)Ljava/lang/String;");
            global::java.lang.Integer._toString3 = env.GetStaticMethodID(global::java.lang.Integer.staticClass, "toString", "(II)Ljava/lang/String;");
            global::java.lang.Integer._toString4 = env.GetStaticMethodID(global::java.lang.Integer.staticClass, "toString", "(I)Ljava/lang/String;");
            global::java.lang.Integer._decode5 = env.GetStaticMethodID(global::java.lang.Integer.staticClass, "decode", "(Ljava/lang/String;)Ljava/lang/Integer;");
            global::java.lang.Integer._valueOf6 = env.GetStaticMethodID(global::java.lang.Integer.staticClass, "valueOf", "(Ljava/lang/String;I)Ljava/lang/Integer;");
            global::java.lang.Integer._valueOf7 = env.GetStaticMethodID(global::java.lang.Integer.staticClass, "valueOf", "(I)Ljava/lang/Integer;");
            global::java.lang.Integer._valueOf8 = env.GetStaticMethodID(global::java.lang.Integer.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Integer;");
            global::java.lang.Integer._reverse9 = env.GetStaticMethodID(global::java.lang.Integer.staticClass, "reverse", "(I)I");
            global::java.lang.Integer._reverseBytes10 = env.GetStaticMethodID(global::java.lang.Integer.staticClass, "reverseBytes", "(I)I");
            global::java.lang.Integer._parseInt11 = env.GetStaticMethodID(global::java.lang.Integer.staticClass, "parseInt", "(Ljava/lang/String;I)I");
            global::java.lang.Integer._parseInt12 = env.GetStaticMethodID(global::java.lang.Integer.staticClass, "parseInt", "(Ljava/lang/String;)I");
            global::java.lang.Integer._bitCount13 = env.GetStaticMethodID(global::java.lang.Integer.staticClass, "bitCount", "(I)I");
            global::java.lang.Integer._getInteger14 = env.GetStaticMethodID(global::java.lang.Integer.staticClass, "getInteger", "(Ljava/lang/String;I)Ljava/lang/Integer;");
            global::java.lang.Integer._getInteger15 = env.GetStaticMethodID(global::java.lang.Integer.staticClass, "getInteger", "(Ljava/lang/String;Ljava/lang/Integer;)Ljava/lang/Integer;");
            global::java.lang.Integer._getInteger16 = env.GetStaticMethodID(global::java.lang.Integer.staticClass, "getInteger", "(Ljava/lang/String;)Ljava/lang/Integer;");
            global::java.lang.Integer._highestOneBit17 = env.GetStaticMethodID(global::java.lang.Integer.staticClass, "highestOneBit", "(I)I");
            global::java.lang.Integer._lowestOneBit18 = env.GetStaticMethodID(global::java.lang.Integer.staticClass, "lowestOneBit", "(I)I");
            global::java.lang.Integer._numberOfLeadingZeros19 = env.GetStaticMethodID(global::java.lang.Integer.staticClass, "numberOfLeadingZeros", "(I)I");
            global::java.lang.Integer._numberOfTrailingZeros20 = env.GetStaticMethodID(global::java.lang.Integer.staticClass, "numberOfTrailingZeros", "(I)I");
            global::java.lang.Integer._rotateLeft21 = env.GetStaticMethodID(global::java.lang.Integer.staticClass, "rotateLeft", "(II)I");
            global::java.lang.Integer._rotateRight22 = env.GetStaticMethodID(global::java.lang.Integer.staticClass, "rotateRight", "(II)I");
            global::java.lang.Integer._signum23 = env.GetStaticMethodID(global::java.lang.Integer.staticClass, "signum", "(I)I");
            global::java.lang.Integer._toBinaryString24 = env.GetStaticMethodID(global::java.lang.Integer.staticClass, "toBinaryString", "(I)Ljava/lang/String;");
            global::java.lang.Integer._toOctalString25 = env.GetStaticMethodID(global::java.lang.Integer.staticClass, "toOctalString", "(I)Ljava/lang/String;");
            global::java.lang.Integer._MIN_VALUE26 = env.GetStaticFieldID(global::java.lang.Integer.staticClass, "MIN_VALUE", "I");
            global::java.lang.Integer._MAX_VALUE27 = env.GetStaticFieldID(global::java.lang.Integer.staticClass, "MAX_VALUE", "I");
            global::java.lang.Integer._TYPE28 = env.GetStaticFieldID(global::java.lang.Integer.staticClass, "TYPE", "Ljava/lang/Class;");
            global::java.lang.Integer._SIZE29 = env.GetStaticFieldID(global::java.lang.Integer.staticClass, "SIZE", "I");
            global::java.lang.Integer.@__ctor30 = env.GetMethodID(global::java.lang.Integer.staticClass, "<init>", "(I)V");
            global::java.lang.Integer.@__ctor31 = env.GetMethodID(global::java.lang.Integer.staticClass, "<init>", "(Ljava/lang/String;)V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)I")]
        public virtual int compareTo(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::java.lang.Integer._compareTo0, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Integer;)I")]
        public virtual int compareTo(global::java.lang.Integer par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::java.lang.Integer._compareTo1, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Ljava/lang/String;")]
        public static global::java.lang.String toHexString(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.CallStaticObjectMethod(global::java.lang.Integer.staticClass, global::java.lang.Integer._toHexString2, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(II)Ljava/lang/String;")]
        public static global::java.lang.String toString(int par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.CallStaticObjectMethod(global::java.lang.Integer.staticClass, global::java.lang.Integer._toString3, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Ljava/lang/String;")]
        public static global::java.lang.String toString(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.CallStaticObjectMethod(global::java.lang.Integer.staticClass, global::java.lang.Integer._toString4, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/lang/Integer;")]
        public static global::java.lang.Integer decode(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Integer>(env.CallStaticObjectMethod(global::java.lang.Integer.staticClass, global::java.lang.Integer._decode5, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;I)Ljava/lang/Integer;")]
        public static global::java.lang.Integer valueOf(global::java.lang.String par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Integer>(env.CallStaticObjectMethod(global::java.lang.Integer.staticClass, global::java.lang.Integer._valueOf6, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Ljava/lang/Integer;")]
        public static global::java.lang.Integer valueOf(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Integer>(env.CallStaticObjectMethod(global::java.lang.Integer.staticClass, global::java.lang.Integer._valueOf7, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/lang/Integer;")]
        public static global::java.lang.Integer valueOf(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Integer>(env.CallStaticObjectMethod(global::java.lang.Integer.staticClass, global::java.lang.Integer._valueOf8, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)I")]
        public static int reverse(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return env.CallStaticIntMethod(global::java.lang.Integer.staticClass, global::java.lang.Integer._reverse9, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)I")]
        public static int reverseBytes(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return env.CallStaticIntMethod(global::java.lang.Integer.staticClass, global::java.lang.Integer._reverseBytes10, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;I)I")]
        public static int parseInt(global::java.lang.String par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return env.CallStaticIntMethod(global::java.lang.Integer.staticClass, global::java.lang.Integer._parseInt11, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)I")]
        public static int parseInt(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return env.CallStaticIntMethod(global::java.lang.Integer.staticClass, global::java.lang.Integer._parseInt12, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)I")]
        public static int bitCount(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return env.CallStaticIntMethod(global::java.lang.Integer.staticClass, global::java.lang.Integer._bitCount13, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;I)Ljava/lang/Integer;")]
        public static global::java.lang.Integer getInteger(global::java.lang.String par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Integer>(env.CallStaticObjectMethod(global::java.lang.Integer.staticClass, global::java.lang.Integer._getInteger14, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/Integer;)Ljava/lang/Integer;")]
        public static global::java.lang.Integer getInteger(global::java.lang.String par0, global::java.lang.Integer par1) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Integer>(env.CallStaticObjectMethod(global::java.lang.Integer.staticClass, global::java.lang.Integer._getInteger15, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/lang/Integer;")]
        public static global::java.lang.Integer getInteger(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Integer>(env.CallStaticObjectMethod(global::java.lang.Integer.staticClass, global::java.lang.Integer._getInteger16, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)I")]
        public static int highestOneBit(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return env.CallStaticIntMethod(global::java.lang.Integer.staticClass, global::java.lang.Integer._highestOneBit17, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)I")]
        public static int lowestOneBit(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return env.CallStaticIntMethod(global::java.lang.Integer.staticClass, global::java.lang.Integer._lowestOneBit18, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)I")]
        public static int numberOfLeadingZeros(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return env.CallStaticIntMethod(global::java.lang.Integer.staticClass, global::java.lang.Integer._numberOfLeadingZeros19, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)I")]
        public static int numberOfTrailingZeros(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return env.CallStaticIntMethod(global::java.lang.Integer.staticClass, global::java.lang.Integer._numberOfTrailingZeros20, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(II)I")]
        public static int rotateLeft(int par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return env.CallStaticIntMethod(global::java.lang.Integer.staticClass, global::java.lang.Integer._rotateLeft21, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(II)I")]
        public static int rotateRight(int par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return env.CallStaticIntMethod(global::java.lang.Integer.staticClass, global::java.lang.Integer._rotateRight22, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)I")]
        public static int signum(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return env.CallStaticIntMethod(global::java.lang.Integer.staticClass, global::java.lang.Integer._signum23, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Ljava/lang/String;")]
        public static global::java.lang.String toBinaryString(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.CallStaticObjectMethod(global::java.lang.Integer.staticClass, global::java.lang.Integer._toBinaryString24, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Ljava/lang/String;")]
        public static global::java.lang.String toOctalString(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.CallStaticObjectMethod(global::java.lang.Integer.staticClass, global::java.lang.Integer._toOctalString25, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::java.lang.Integer(env);
            }
        }
    }
    #endregion
}