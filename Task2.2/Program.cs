using System;

var l1 = new Lection("description l1","topic 1");
var pr1 = new PracticalLesson("description pr1", "Condition 1", "Solution 1");
var pr2 = new PracticalLesson("description pr2");
var tr = new Training(pr2, pr1);

Console.WriteLine(tr.IsPractical());

tr.Add(l1);

Console.WriteLine(tr.IsPractical());

var k = tr.Clone();

var l2 = new Lection("description l2");

k.Add(l2);