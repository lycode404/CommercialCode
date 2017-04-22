# CommercialCode
这是一个可以转换摩尔斯电码和中文电码的.net类库。  
调用该类库的方法（以c#为例）：  
1,在你的.net工程中找到解决方案资源管理器，右键点击“引用”-“添加引用”-“浏览”，选择commericialcode.dll  
2,在代码文件开头处添加以下语句
```
using CommercialCode;
```
然后在相应的位置键入你需要的实例化语句：

```
MorseCode 对象名 = new MorseCode();//摩尔斯电码
ChineseCommercialCode 对象名 = new ChineseCommercialCode();//中文电码
```
输入这些代码即可实现文字与电码的转换：

```
textBox2.Text = 对象名.TextToCode(textBox1.Text);//文字转电码（参数：string，返回：string）
textBox3.Text = 对象名.CodeToText(textBox4.Text);//电码转文字（参数：string，返回：string）
```

你还可以设置电码点横的样式（仅限摩尔斯电码）：

```
对象名.point=string;
对象名.line=string;
```
使用这个类库，只需要几行代码，即可快速转换文本和电码  
该类库目前已收录6000多个汉字的电码和完整的摩尔斯电码。

最后附该类库的对象浏览器视图：
![image](https://raw.githubusercontent.com/lycode404/CommercialCode/master/image/cncode.png)  
![image](https://raw.githubusercontent.com/lycode404/CommercialCode/master/image/morsecode.png)
