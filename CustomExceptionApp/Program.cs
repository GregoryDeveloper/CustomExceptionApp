using System;
using System.Net;
using CustomExceptionApp.Exceptions;

namespace CustomExceptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomExceptionCaughtByException();
            CustomExceptionCaughtByCustomException();
            CustomExceptionThrownWithExtraParameter();
            CustomArgumentNullExceptionCaughtByArgumentNullException();
            CustomArgumentNullExceptionCaughtByCustomArgumentNullException();
            Console.ReadKey();
        }

        private static void CustomExceptionCaughtByException()
        {
            try
            {
                throw new CustomException("custom exception message");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Caught in block exception with message: {ex.Message}");
            }
        }

        private static void CustomExceptionCaughtByCustomException()
        {
            try
            {
                throw new CustomException("custom exception message");
            }
            catch(CustomException ex)
            {
                Console.WriteLine($"Caught in block CustomException with message: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Caught in block exception with message: {ex.Message}");
            }
        }

        private static void CustomExceptionThrownWithExtraParameter()
        {
            try
            {
                throw new CustomException("custom exception message",HttpStatusCode.OK);
            }
            catch (CustomException ex)
            {
                Console.WriteLine($"Caught in block CustomException with message: {ex.Message} and with httpStatusCode: {ex.StatusCode}");
            }
        }

        private static void CustomArgumentNullExceptionCaughtByArgumentNullException()
        {
            try
            {
                throw new CustomArgumentNullException("custom exception message", "AnyField");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Caught in block ArgumentNullException with message: {ex.Message} and with httpStatusCode: {ex.ParamName}");
            }
        }

        private static void CustomArgumentNullExceptionCaughtByCustomArgumentNullException()
        {
            try
            {
                throw new CustomArgumentNullException("custom exception message", "AnyField");
            }
            catch (CustomArgumentNullException ex)
            {
                Console.WriteLine($"Caught in block CustomArgumentNullException with message: {ex.Message} and with paramName: {ex.ParamName}");
            }
        }
    }
}
