# 02_LearnUnitTest

以四則運算(Elementary arithmetic)為例子實作演算法單元測試。

## 1. Features【功能】
* PortalLibrary: 四則運算函式庫。
* Portal : 四則運算輸出Application，使用MVC輸出。 
* PortalTests: 單元測試PortalLibrary四則運算函式庫。

## 2. Platforms【程式平台】
* C#+MVC

## 3. Usage【如何使用】

```cs
 public ActionResult Index()
 {
    var Result = RelArithmeticBase.Addition(1, 1);
    var ResultSecound = RelArithmeticBase.AdditionSecound(2.0, 2.1);
    var ResultThird = RelArithmeticBase.Division(22.0, -7.0);

     ViewData["Result"] = Result;
     ViewData["ResultSecound"] = ResultSecound;
     ViewData["ResultThird"] = ResultThird;
     
     return View();
}
