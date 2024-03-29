﻿// See https://aka.ms/new-console-template for more information

using CommandDesignPattern.Data;
using CommandDesignPattern.Infra.Commands;
using CommandDesignPattern.Infra.Invoker;
using CompositeDesignPattern.Infra;
using CompositeDesignPattern.Interface;
using Eshop_DataAccess.Infra;
using Eshop_DataAccess.Infra.Commands;
using Eshop_DataAccess.Infra.Enums;
using Eshop_DataAccess.InterFace;
using Eshop_DataAccess.Repositories;

#region Wrapper
static void PrintCart(ShoppingCartRepository shoppingCartRepository)
{
    var totalPrice = 0m;
    foreach (var lineItem in shoppingCartRepository.LineItems)
    {
        var price = lineItem.Value.Product.Price * lineItem.Value.Quantity;

        Console.WriteLine($"{lineItem.Key} " +
            $"${lineItem.Value.Product.Price} x {lineItem.Value.Quantity} = ${price}");

        totalPrice += price;
    }

    Console.WriteLine($"Total price:\t${totalPrice}");
}
#endregion
#region EshopDataAccess


var shoppingCartRepository = new ShoppingCartRepository();
var productsRepository = new ProductRepository();

var product = productsRepository.FindBy("SM7B");

var addToCartCommand = new AddToCartCommand(shoppingCartRepository,
    productsRepository,
    product);

var increaseQuantityCommand = new ChangeQuantityCommand(
    Operation.Increase,
    shoppingCartRepository,
    productsRepository,
    product);

var manager = new CommandManager();
manager.Invoke(addToCartCommand);
manager.Invoke(increaseQuantityCommand);
manager.Invoke(increaseQuantityCommand);
manager.Invoke(increaseQuantityCommand);
manager.Invoke(increaseQuantityCommand);

PrintCart(shoppingCartRepository);

manager.Undo();

PrintCart(shoppingCartRepository);
#endregion
#region CompositDesignPattern

//Console.WriteLine("****** Asset Price *******");


//Creating Leaf Objects
//ICustomComponent cpu = new Leaf("CPU", 10);
//ICustomComponent ram = new Leaf("RAM", 10);
//ICustomComponent hardDisk = new Leaf("Hard Disk", 10);
//ICustomComponent mouse = new Leaf("Mouse", 10);
//ICustomComponent keyboard = new Leaf("Keyboard", 50);

////Creating composite objects
//ICustomComponent motherBoard = new Composite("Board");
//ICustomComponent cabinet = new Composite("cabinet");
//ICustomComponent peripherals = new Composite("Peripherals");

////Whole Device
//ICustomComponent computer = new Composite("Computer");


////Creating tree structure

////Ading CPU and RAM in Mother board
//motherBoard.AddComponent(cpu);
//motherBoard.AddComponent(ram);
////Ading mother board and hard disk in Case
//cabinet.AddComponent(motherBoard);
//cabinet.AddComponent(hardDisk);
////Ading mouse and keyborad in peripherals
//peripherals.AddComponent(mouse);
//peripherals.AddComponent(keyboard);
////Ading cabinet and peripherals in computer
//computer.AddComponent(cabinet);
//computer.AddComponent(peripherals);

////To display the Price of the Computer
//var Price = computer.CalculatePrice();

//Console.WriteLine(Price.ToString());
//Console.WriteLine();


#endregion

#region CommandDesignPattern

//var dataReceiver = new DataReceiver();
//var invoker = new DataCommandInvoker();
//invoker.SetCommand(new UpsertCommand("Name","Ashkan",dataReceiver));
//invoker.ExecuteCommand();
//invoker.SetCommand(new DeleteCommand("Name",dataReceiver));
//invoker.ExecuteCommand();
//Console.ReadKey();


#endregion