﻿using G.ChainOfResponsibility.Pattern;
using G.ChainOfResponsibility.Pattern.Handlers;
using G.ChainOfResponsibility.Pattern.Handlers.Interfaces;
using System;

namespace G.ChainOfResponsibility
{
    //Паттерн цепочка обязанностей проще всего объясняется примером из жизни, когда мы идем в поликлинику, но при этом точно не знаем характер
    //заболевания. Сначала мы идем к терапевту, а он в зависимости от заболевания уже может либо сам лечить, либо отправить на лечение к другим
    //специализироанным врачам. Или вот чиновники перекладывают друг на друга по цепочке выполнения какое-либо дело, а оно в конце концов
    //оказывается не выполненным.
    //И вот тут же выресовывается недостаток паттерна. Никто не гарантирует, какое-либо дело будет выполнено. Если необходимого обработчика
    //в цепочке не окажется, то дело просто выходит из цепочки и остается не выполненным. Классическая бюрократическая модель.

    //Короче говоря цепочка обязанностей- поведенческий шаблон проектирования, который позволяет избежать жесткой привязки отправителя запроса
    //к получателю. Все возможные обработчики запроса образуют цепочку, а сам запрос перемещаетсяпо этой цепочке. Каждый объект в этой цепочке
    //при получении запроса выбирает либо закончить обработку запроса, либо передать запрос на обработку следующему по цепочке объекту.
    //Паттерн стоит применять:
    // 1) Когда имеется более одного объекта, который может обработать запрос;
    // 2) Когда надо передать запрос на выполнение одному из нескольких объектов, точно не определяя, какому именно.
    // 3) Когда набор объектов задается динамически.

    //Конкретный пример. Нам нужно отправить человеку некую сумму дененг. Обнако мы не знаем точно, какой способ отправки может быть использован:
    //простой банковский перевод, или система онлайн платежей, или пэйпэл. Нам надо просто внести сумму, выбрать человека и нажать на кнопку.
    //То есть точные данные получателя нам знать вовсе необязательно. В классе получателя с помощью конструктора мы определим возможные системы
    //платежей. При осуществлении платежа каждый отдельный объект обработчика будет проверять установку у получателя конкретного типа платежей. И
    //если произойдет сопоставление типа платежей у получателя объекту обработчика платежей, то данный объект выполняет платеж. Если же необходимого
    //способа платежей не будет определено, то деньги остаются в системе. При этом преимуществом цепочки является и то, что она позволяет расположить
    //последовательность объектов-обработчиков в ней в зависимости от их приоритета.
    class Program
    {
        static void Main(string[] args)
        {
            Receiver receiver = new Receiver(false, true, true);

            PaymentHandler bankPaymentHandler = new BankPaymentHandler();
            PaymentHandler moneyPaymentHandler = new MoneyPaymentHandler();
            PaymentHandler paypalPaymentHandler = new PayPalPaymentHandler();

            bankPaymentHandler.Successor = paypalPaymentHandler;
            paypalPaymentHandler.Successor = moneyPaymentHandler;

            bankPaymentHandler.Handle(receiver);


        }
    }
}