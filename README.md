# VictorianPlumbingTest

There are 3 tables. They can be added using below scripts<br>
[Order](https://github.com/ycangi1/VictorianPlumbingTest/blob/master/VictorianPlumbingTest.Database/dbo/Tables/Order.sql)<br>
[Product](https://github.com/ycangi1/VictorianPlumbingTest/blob/master/VictorianPlumbingTest.Database/dbo/Tables/Product.sql)<br>
[Product Order](https://github.com/ycangi1/VictorianPlumbingTest/blob/master/VictorianPlumbingTest.Database/dbo/Tables/ProductOrder.sql)<br>

API is using Swagger for the UIa and Automappe for mapping objects. 

Connection string is hard-coded in the [dependency injection file](https://github.com/ycangi1/VictorianPlumbingTest/blob/master/VictorianPlumbingTest.Repository/DependencyInjection.cs). This would be in a config file if given more time.<br>
