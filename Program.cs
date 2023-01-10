#Найти сумму нечетны йцифр в массиве
def SumOfOddNumbers(List):
    summa = 0 
    for number in List:
        if number % 2:
            summa += number
    return summa
 
def  SameDigits(number):
    n = str(number)
    return n == n[::-1]
 
def ReverseLocation(number):
    return str(number)[::-1]
 
def PrimeNumber(x):
    if x == 1:
        return 0
    for i in range(2, x):
        if x % i == 0:
            return 0
    return x
 
List = [1, 2, 3, 4, 5, 6]
sum_ = SumOfOddNumbers(List)
print('Сумма нечетных чисел - ', sum_)





#Напишите программу, которая найдёт разницу между максимальным и минимальным значением
list = [1, 4, 8, 10, 3, 5]
myMax = list[0]
myMin = list[0]

for i in range(len(list)):
    if list[i] > myMax : myMax=list[i]
    if list[i] < myMin : myMin=list[i]

print (myMax, '-', myMin, '=', myMax - myMin)







# Напишите программу, которая будет преобразовывать десятичное число в двоичное.
print ('Введите число в десятичной системе отсчета: ')
num = int(input())
new_num = ''

while num > 0:
    new_num = str(num % 2) + new_num
    num //= 2

print('Число в двоичной системе отсчета: ',  new_num)