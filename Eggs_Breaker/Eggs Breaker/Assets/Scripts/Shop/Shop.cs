using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Shop
{
    [Serializable]
    public class Items
    {
        public Sprite Sprite;
        public int Price;
    }
    
    public class Shop : MonoBehaviour
    {
        [SerializeField] private Button _buttonNext;
        [SerializeField] private Button _buttonPrevious;
        [SerializeField] private Image _image;
        [SerializeField] private TextMeshProUGUI _priceText;
        [SerializeField] private List<Items> _items;

        private int _i;

        private void Awake()
        {
            _buttonNext.onClick.AddListener(Next);
            _buttonPrevious.onClick.AddListener(Previous);
            
            _image.sprite = _items[0].Sprite;
            _priceText.text = $"BUY {_items[0].Price}$";
        }

        private void Next()
        {
            _i++;
            if (_i >= _items.Count) _i = 0;

            _image.sprite = _items[_i].Sprite;
            _priceText.text = $"BUY {_items[_i].Price}$";
        }

        private void Previous()
        {
            _i--;
            if (_i < 0) _i = _items.Count - 1;
            
            _image.sprite = _items[_i].Sprite;
            _priceText.text = $"BUY {_items[_i].Price}$";
        }
    }
}
