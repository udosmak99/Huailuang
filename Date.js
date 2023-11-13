                var curDate, CurMonth, CurYear;
                var txt;
                function CreateLink(Click, text) {
                        var a = document.createElement('a');
                        a.innerText = text;

                        if (Click != null) {
                                a.setAttribute('onclick', Click);
                                a.style.cursor = 'pointer';
                                a.style.textDecoration = 'underline';
                        }
                        return a;
                }
              
                Date.prototype.getMonthName = function (lang) {
                        lang = lang && (lang in Date.locale) ? lang : 'en';
                        return Date.locale[lang].month_names[this.getMonth()];
                };

                Date.prototype.getMonthNameShort = function (lang) {
                        lang = lang && (lang in Date.locale) ? lang : 'en';
                        return Date.locale[lang].month_names_short[this.getMonth()];
                };

                Date.locale = {
                        en: {
                                month_names: ['January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December'],
                                month_names_short: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec']
                        }
                };
                Date.locale = {
                        th: {
                                month_names: ['มกราคม', 'กุมภาพันธ์', 'มีนาคม', 'เมษายน', 'พฤษภาคม ', 'มิถุนายน ', 'กรกฎาคม ', 'สิงหาคม ', 'กันยายน ', 'ตุลาคม ', 'พฤศจิกายน ', 'ธันวาคม '],
                                month_names_short: ['ม.ค.', 'ก.พ', 'มี.ค.', 'เม.ย.', 'พ.ค.', 'มิ.ย.', 'ก.ค.', 'ส.ค.', 'ก.ย.', 'ต.ค.', 'พ.ย.', 'ธ.ค.']
                        }
                };
                function ClickSelectDate(D) {
                        var D = new Date(CurYear,CurMonth,D);
                        txt.value = D.getDate().toString() + '/' + D.getMonthName('th') + ' / ' + D.getYear().toString();
                        tbDate.style.display = 'none';

                }
                function SelectToday() {
                        var D = new Date();
                        lbToday.innerHTML = D.getDate().toString() + '/' + D.getMonthName('th') + ' / ' + D.getYear().toString();
                        txt.value = D.getDate().toString() + '/' + D.getMonthName('th') + ' / ' + D.getYear().toString();
                        tbDate.style.display = 'none';
                        
                }  
                function InitDate() {
                        var D = new Date();
                        curDate = D.getDate();
                        CurMonth = D.getMonth();
                        CurYear = D.getYear();
                        FillMonth(1, CurMonth, CurYear);
                        lbMonth.innerHTML = D.getMonthName('th') + ' / ' + CurYear.toString();
                        lbToday.innerHTML =curDate .toString () +'/' + D.getMonthName('th') + ' / ' + CurYear.toString(); ;

                }
                function FillMonth(D, M, Y) {
                        Clear();
                        var DD = new Date(Y, M, D);
                        var Begin = (DD.getDay());
                       var End =32 - new Date(Y, M, 32).getDate();
                       var Ds = tbDate.getElementsByTagName("a");
                       var ObjP;
                       for (x = D - 1; x < End; x++) {
                               ObjP = Ds[x + Begin].parentElement;
                               ObjP.innerHTML = "<a    style='cursor:pointer; text-decoration: underline'  onclick = 'ClickSelectDate(" + ((x + 1).toString()) + ")' >" + (x + 1).toString() + "</a>";
                       }
               }
               function Clear() {
                       var Ds = tbDate.getElementsByTagName("a");
                       for (x = 0; x < Ds.length; x++) {
                               Ds[x].innerHTML = '&nbsp';
                               Ds[x].setAttribute('onclick', '');
                       }

               }
               function Previous() {
                       if (CurMonth == 0) {
                               CurMonth = 11;
                               CurYear--;
                       }
                       else {
                               CurMonth--;
                       }
                       FillMonth(1, CurMonth, CurYear);
               }

               function Next() {
                       if (CurMonth == 11) {
                               CurMonth = 0;
                               CurYear++;
                       }
                       else {
                               CurMonth++;

                       }
                       FillMonth(1, CurMonth, CurYear);
               }
               

               function findPos(obj) {
                       var curleft = curtop = 0;
                       if (obj.offsetParent) {
                               curleft = obj.offsetLeft
                               curtop = obj.offsetTop
                               while (obj = obj.offsetParent) {
                                       curleft += obj.offsetLeft
                                       curtop += obj.offsetTop
                               }
                       }
                        return [curleft, curtop];
               }

               function SelectDate(C) {
                       //alert(CurYear);
                       InitDate();
                       alert(CurYear);
                       txt = document.getElementById(C);
                        var Pos = findPos(txt);
                        tbDate.style.top = (Pos[1] + txt.offsetHeight +20);
                       tbDate.style.left = Pos[0];
                       tbDate.style.display = 'block';
               }

