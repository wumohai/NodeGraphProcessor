# NodeGraphProcessor + Odin
Node graph editor framework focused on data processing using Unity UIElements, GraphView and C# 4.7

这个项目是本人NodeGraphProcessor接入Odin序列化的示例。**本仓库将持续跟进更新。 目前已同步更新至 https://github.com/alelievr/NodeGraphProcessor/commit/ba0468c2edc067ab7376d3f67daef80eeefa380f**

NodeGraphProcessor版本：https://github.com/alelievr/NodeGraphProcessor/

Odin插件官网地址：https://odininspector.com/

相关博客：https://www.lfzxb.top/nodegraphprocesssor-and-odin/

## 功能

 - 接入Odin序列化
 - 支持List，Dictionary，HashSet，Stack等泛型集合序列化与可视化

## TODO

 - [ ] 在Inseoctor面板修改的Node数据需要即时渲染在Graph上。原因是仓库原生版本是用了BaseNodeView + NodeCustomEditor做协调同步，而我们使用Odin序列化后就丢失了特定NodeView的相关信息，待修复
 - [ ] 不同的Graph需要有不同的节点搜索范围。例如行为树Graph在创建节点时只会搜索行为树相关节点内容而不会搜索到碰撞关系编辑器相关节点内容
 - [x] ~~优化节点之间值传递消耗~~ (由于支持自定义每个端口的处理，所以自定义节点值传递已无优化空间，只能通过反射进行，但这种反射传递值只发生在进行自定义端口处理的时候，默认情况下是直接通过表达式树赋值的，效率尚可）
 - [ ] 优化一些反射操作的扫描程序集范围，现在耗时非常严重，甚至还扫描了mscorlib程序集中的类型

## 截图

![](./Pngs/QQ截图20210404172603.png)
![](./Pngs/QQ截图20210404172629.png)
![](./Pngs/QQ截图20210404172705.png)
![](./Pngs/QQ截图20210404172717.png)
![](./Pngs/QQ截图20210404172725.png)
![](./Pngs/QQ截图20210404172956.png)
