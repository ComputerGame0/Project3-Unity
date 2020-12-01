# Project3-Unity
<div dir='rtl' lang='he'>
 
# Mario
![mario](https://user-images.githubusercontent.com/58064644/100764249-cf720d00-33fe-11eb-8cf0-a42f0310ce84.png)
 
 
במשחק בנינו ארבעה שלבים, 
בכל שלב הרמה עולה.

## שלב ראשון :

מריו אוסף מטבעות, קופץ מעל מכשולים
<br />.וצריך להזהר לא ליפול למים, אחרת יחזור לתחילת השלב
ישנם פלטפורמות הבאות לעזרתו לאסיפת המטבעות הנמצאות גבוה
ברגע שמריו מתנגש בפלטפורמה, הוא יתפס עליה ולא יפול ממנה עד שיקפוץ ממנה.
הקוד שאחראי על הצמדות לפלטפורמה:

[תלחץ כאן על מנת לראות את הקוד האחראי](https://github.com/ComputerGame0/Project3-Unity/blob/main/Assets/Scripts/MovingPlatform.cs)


![madaf](https://user-images.githubusercontent.com/57682267/100767137-144b7300-3402-11eb-81f9-ddde0543fecc.jpg)


## שלב שני :
<br />מריו פוגש בפטריות רעות היוכולות לגרום לפסילתו
<br />במידה ומריו מפעיל מספיק כח כאשר נפגש בפטריות
.הוא מצליח להשמידם<br />
,נעזרנו בחוקי הפיזיקה
כאשר מריו מתנגש בפטריות<br />
<br />נבדוק מהו הכח של מריו
<br />במידה והכח שהפעיל גדול מהכוח המינימיל שהגדרנו
מריו יצליח להביס את הפטריות.<br />
<br />במידה ומריו לא הפעיל מספיק כח
מריו יפסל ויחזור לתחילת השלב.<br />
כאשר נרצה לבדוק האם מריו הפעיל מספיק בכוח 
נשתמש בשאלה זו : <br />
impulse < minImpulseForExplosion <br />
 הינו הכח הימינימלי שצריך לפהעיל על מנת לנצח את האויב minImpulseForExplosion  כאשר 
<br />
[תלחץ כאן על מנת לראות את הקוד האחראי](https://github.com/ComputerGame0/Project3-Unity/blob/main/Assets/Scripts/OnTriggerEnemy.cs)
<br />
![level2](https://user-images.githubusercontent.com/57682267/100767194-26c5ac80-3402-11eb-8ef7-1f61f052a45a.jpg)


## שלב שלישי :

.<br />מריו מקבל כח נוסף- כנפיים
<br />בעזרתם יכול לעבור את השלב
<br />מריו קופץ על הכנפיים ונתפס בהם ועובר מעל המים והמכשולים
ללא הכנפיים אין למריו את היכולת לעבור את השלב.<br />
<br />בקוד: זיהינו התנגשות, ברגע המפגש הכנפיים הופכות להיות 
ה parent של מריו
<br />
[תלחץ כאן על מנת לראות את הקוד האחראי](https://github.com/ComputerGame0/Project3-Unity/blob/main/Assets/Scripts/MovingPlatform.cs)


![wings1](https://user-images.githubusercontent.com/57682267/100767244-33e29b80-3402-11eb-9fd6-13b627fbb97d.jpg)
 
 
## שלב רביעי :
רח חזקה הגורמת להאטת קצב ההתקדמות של מריו.<br />
<br />ברגע המפגש של מריו עם טווח הרוח
<br />קצב ההליכה של מריו יורד
ויצטרך לעבור את אזור הענן כדי לחזור למהירותו המקורית.<br />


הקוד האחראי על שינוי המהירות של מריו  :<br />
<br />
[תלחץ כאן על מנת לראות את הקוד האחראי](https://github.com/ComputerGame0/Project3-Unity/blob/main/Assets/Scripts/WindVelocity.cs)


![hanan](https://user-images.githubusercontent.com/57682267/100767282-40ff8a80-3402-11eb-85c5-5eb668732fdd.png)


על מנת לעבור לשלב הבא :
[תלחץ כאן על מנת לראות את הקוד האחראי](https://github.com/ComputerGame0/Project3-Unity/blob/main/Assets/Scripts/NextLevel.cs)
<br />

![next levelpng](https://user-images.githubusercontent.com/57682267/100767335-507ed380-3402-11eb-827f-af75a6a1bcab.png)


לאחר שמריו עבר את כל השלבים :

![finish](https://user-images.githubusercontent.com/57682267/100767368-5d032c00-3402-11eb-9b5b-dbd168241260.png)



