using System.Collections.Generic;
using System;

namespace CarShop.Models
{
  public class Car
  {
    private static List<Car> _instances = new List<Car> {};
    private string _model;
    private int _price;
    private int _miles;

    public Car (string carModel, int carPrice, int carMiles)
    {
      _model = carModel;
      _price = carPrice;
      _miles = carMiles;
    }
    public string GetModel()
    {
      return _model;
    }
    public void SetModel(string newModel)
    {
      _model = newModel;
    }
    public int GetPrice()
    {
      return _price;
    }
    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }
    public int GetMiles()
    {
      return _miles;
    }
    public void SetMiles(int newMiles)
    {
      _miles = newMiles;
    }
    public static List<Car> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
