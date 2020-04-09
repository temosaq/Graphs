﻿namespace Service.Models {
    public class Node {
        public Node(string label) {
            Label = label;
        }

        public Node() {
        }
        public int Id { get; set; }

        public string Label { get; set; }
        public string Uid { get; set; }
        
    }
}