using System;
using Machine.Specifications;

namespace FizzBuzz.Tests
{
    internal class FizzBuzzerTests
    {
        [Subject(typeof (FizzBuzzer))]
        public class When_passed_a_number_that_is_too_high
        {
            private static Exception exception;
            private static IFizzBuzzer fizzbuzzer;

            private Establish context = () => { fizzbuzzer = new FizzBuzzer(); };

            private Because of = () => exception = Catch.Exception(() => fizzbuzzer.Print(101));

            private It should_throw_a_exception = () => exception.ShouldNotBeNull();
        }

        [Subject(typeof (FizzBuzzer))]
        public class When_passed_a_number_that_is_too_low
        {
            private static Exception exception;
            private static IFizzBuzzer fizzbuzzer;

            private Establish context = () => { fizzbuzzer = new FizzBuzzer(); };

            private Because of = () => exception = Catch.Exception(() => fizzbuzzer.Print(0));

            private It should_throw_a_exception = () => exception.ShouldNotBeNull();
        }

        [Subject(typeof (FizzBuzzer))]
        public class When_passed_a_valid_number
        {
            private static IFizzBuzzer fizzbuzzer;

            private Establish context = () => { fizzbuzzer = new FizzBuzzer(); };

            private It eightyeight_should_print_number = () => fizzbuzzer.Print(88).ShouldEqual("88");
            private It fifthteen_should_print_fizzbuzz = () => fizzbuzzer.Print(15).ShouldEqual("FizzBuzz");

            private It five_should_print_buzz = () => fizzbuzzer.Print(5).ShouldEqual("Buzz");
            private It one_should_print_number = () => fizzbuzzer.Print(1).ShouldEqual("1");
            private It six_should_print_fizz = () => fizzbuzzer.Print(6).ShouldEqual("Fizz");
            private It ten_should_print_buzz = () => fizzbuzzer.Print(10).ShouldEqual("Buzz");

            private It thirteen_should_print_fizzbuzz = () => fizzbuzzer.Print(30).ShouldEqual("FizzBuzz");
            private It three_should_print_fizz = () => fizzbuzzer.Print(3).ShouldEqual("Fizz");
        }
    }
}