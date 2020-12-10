# Build With Donet 4.7.2

# CSharpAttribute
 cshap属性学习笔记

# BitwiseLearning
- 位移操作
-  https://docs.microsoft.com/zh-cn/dotnet/csharp/language-reference/operators/bitwise-and-shift-operators?f1url=%3FappId%3DDev16IDEF1%26l%3DZH-CN%26k%3Dk(%7C_CSharpKeyword);k(TargetFrameworkMoniker-.NETFramework,Version%253Dv4.7.2);k(DevLang-csharp)%26rd%3Dtrue
- ~ 一元 按位求补 
	[运算符：0b_1111_0000{124}  ，按位求补后则是0b_0000_1111{-124}]
- << >> 左移右移操作符 
	[0b_0000_0000_0000_0000_0000_0000_0000_0001{1} << 1 == 0b_0000_0000_0000_0000_0000_0000_0000_0010{2}]
- & ^ 运算符 
	[0b_1111_1000 & 0b_1001_1101 == 0b_1001_1000(取最小)]
	[0b_1111_1000 ^ 0b_1001_1101 == 0b_1111_1101(取最大)]
- 位移运算符与枚举操作