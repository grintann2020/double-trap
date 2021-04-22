using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace T {

    public class LangMgr : Sgltn<LangMgr> {

        private object[][][] _termArr;
        private ELang _eCurrLang;
        private ELang[] _sysLangArr = new ELang[] { // the array tf ELang, which contrast system language
            ELang.AF, /* Afrikaans = 0 */ ELang.AR, /* Arabic = 1 */
            ELang.EU, /* Basque = 2 */ ELang.BE, /* Belarusian = 3 */ ELang.BG, /* Bulgarian = 4 */
            ELang.CA, /* Catalan = 5 */ ELang.ZH_CN, /* Chinese = 6 */ ELang.CS, /* Czech = 7 */
            ELang.DA, /* Danish = 8 */ ELang.NL, /* Dutch = 9 */
            ELang.EN, /* English = 10 */ ELang.ET, /* Estonian = 11 */
            ELang.FO, /* Faroese = 12 */ ELang.FI, /* Finnish = 13 */ ELang.FR, /* French = 14 */
            ELang.DE, /* German = 15 */ ELang.EL, /* Greek = 16 */
            ELang.HE, /* Hebrew = 17 */ ELang.HU, /* Hungarian = 18 */
            ELang.IS, /* Icelandic = 19 */ ELang.ID, /* Indonesian = 20 */ ELang.IT, /* Italian = 21 */
            ELang.JA, /* Japanese = 22 */
            ELang.KO, /* Korean = 23 */
            ELang.LV, /* Latvian = 24 */ ELang.LT, /* Lithuanian = 25 */
            ELang.NO, /* Norwegian = 26 */
            ELang.PL, /* Polish = 27 */ ELang.PT, /* Portuguese = 28 */
            ELang.RO, /* Romanian = 29 */ ELang.RU, /* Russian = 30 */
            ELang.SH, /* SerboCroatian = 31 */ ELang.SK, /* Slovak = 32 */ ELang.SL, /* Slovenian = 33 */ ELang.ES, /* Spanish = 34 */ ELang.SV, /* Swedish = 35 */
            ELang.TH, /* Thai = 36 */ ELang.TR, /* Turkish = 37 */
            ELang.UK, /* Ukrainian = 38 */
            ELang.VI, /* Vietnamese = 39 */
            ELang.ZH_CN, /* ChineseSimplified = 40 */ ELang.ZH_TW, /* ChineseTraditional = 41 */
            ELang.EN, /* Unknow = 42 */
        };
        private List<Text> _txtLst;

        public void Bind(ILangPrm iLangPrm) {
            _termArr = iLangPrm.TermArr;
        }

        public void Init() {
            _eCurrLang = ELang.EN;
        }

        public void Chg(byte eLang) {
            if ((ELang)eLang == _eCurrLang) {
                return;
            }
            _eCurrLang = (ELang)eLang;
        }

        public void Chg(ELang eLang) {
            if (eLang == _eCurrLang) {
                return;
            }
            _eCurrLang = eLang;
        }

        public void Chg(SystemLanguage sysLang) {
            if (_sysLangArr[(byte)sysLang] == _eCurrLang) {
                return;
            }
            _eCurrLang = _sysLangArr[(byte)sysLang];
        }

        public string Term(ushort eTerm) {
            // _termArr[eTerm][t] -- term in multiple language
            // _termArr[eTerm][t][0] -- ELang
            // _termArr[eTerm][t][0] -- System.String
            for (byte t = 0; t < _termArr[eTerm].Length; t++) {
                if ((ELang)_termArr[eTerm][t][0] == _eCurrLang) {
                    return (string)_termArr[eTerm][t][1];
                }
            }
            return (string)_termArr[eTerm][0][1];
        }

        public string Term(ushort eTerm, ELang eLang) {
            for (byte t = 0; t < _termArr[eTerm].Length; t++) {
                if ((ELang)_termArr[eTerm][t][0] == eLang) {
                    return (string)_termArr[eTerm][t][1];
                }
            }
            return (string)_termArr[eTerm][0][1];
        }

        public void Txt() {

        }
    }
}