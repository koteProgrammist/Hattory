using System;
using Cosmos;
using scr = Hattory.Kernel;

namespace Hattory
{
    public class Font8x8
    {
        /*{
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0 };
        */

        #region Chars
        //7x13
        public static Byte[] Dote = { 
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            1, 1, 1, 0, 0, 0, 0,
            1, 1, 1, 0, 0, 0, 0,
            1, 1, 1, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0 };

        public static Byte[] NotF = { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 };

        public static Byte[] Utro = { 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static Byte[] Fill = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

        public static Byte[] zapapa = { 
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 1, 1, 0, 0, 0, 0,
            0, 1, 1, 0, 0, 0, 0,
            0, 0, 1, 0, 0, 0, 0,
            0, 0, 1, 0, 0, 0, 0,
            0, 1, 0, 0, 0, 0, 0 };

        public static Byte[] kov = { 
            0, 1, 1, 0, 1, 1, 0,
            0, 1, 1, 0, 1, 1, 0,
            0, 1, 1, 0, 1, 1, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0 };

        public static Byte[] vopros = {
            0, 0, 0, 1, 0, 0, 0,
            0, 0, 1, 1, 1, 0, 0,
            0, 1, 1, 0, 1, 1, 0,
            1, 1, 0, 0, 0, 1, 1,
            0, 0, 0, 0, 0, 1, 1,
            0, 0, 0, 0, 1, 1, 0,
            0, 0, 0, 0, 1, 1, 0,
            0, 0, 0, 1, 1, 0, 0,
            0, 0, 0, 1, 1, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 1, 1, 0, 0,
            0, 0, 0, 1, 1, 0, 0,
            0, 0, 0, 0, 0, 0, 0 };


        public static Byte[] sobaka = {
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0 };

        public static Byte[] resh = {
            0, 1, 0, 1, 0,
            0, 1, 0, 1, 0,
            1, 1, 1, 1, 1,
            0, 1, 0, 1, 0,
            0, 1, 0, 1, 0,
            1, 1, 1, 1, 1,
            0, 1, 0, 1, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] dollar = {
            0, 0, 1, 0, 0,
            0, 1, 1, 1, 0,
            1, 0, 1, 0, 1,
            1, 0, 1, 0, 0,
            0, 1, 1, 1, 0,
            0, 0, 1, 0, 1,
            1, 0, 1, 0, 1,
            0, 1, 1, 1, 0,
            0, 0, 1, 0, 0,};

        public static Byte[] xyi = {
            0, 0, 1, 0, 0,
            0, 1, 0, 1, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] andd = {
            0, 0, 1, 0, 0,
            0, 1, 0, 1, 0,
            1, 0, 0, 1, 0,
            1, 0, 1, 0, 0,
            0, 1, 0, 0, 0,
            1, 0, 1, 0, 1,
            1, 0, 0, 1, 0,
            0, 1, 1, 0, 1,
            0, 0, 0, 0, 0 };

        public static Byte[] zvezda = {
            1, 0, 1, 0, 1,
            1, 0, 1, 0, 1,
            0, 1, 1, 1, 0,
            1, 1, 1, 1, 1,
            0, 1, 1, 1, 0,
            1, 0, 1, 0, 1,
            1, 0, 1, 0, 1,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] Sopen = {
            0, 1, 0, 0, 0,
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            0, 1, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] Sclose = {
            0, 0, 0, 1, 0,
            0, 0, 0, 0, 1,
            0, 0, 0, 0, 1,
            0, 0, 0, 0, 1,
            0, 0, 0, 0, 1,
            0, 0, 0, 0, 1,
            0, 0, 0, 1, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] procent = {
            1, 1, 1, 0, 0,
            1, 0, 1, 0, 0,
            1, 1, 1, 0, 1,
            0, 0, 0, 1, 0,
            0, 0, 1, 0, 0,
            0, 1, 0, 0, 0,
            1, 0, 1, 1, 1,
            0, 0, 1, 0, 1,
            0, 0, 1, 1, 1 };

        public static Byte[] defis = { 
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 1, 1, 1, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] loll = { 
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            1, 1, 1, 1, 1 };

        public static Byte[] CapA = { 
            1, 0, 0, 0, 0,
            1, 1, 0, 0, 0,
            1, 0, 1, 0, 0,
            1, 0, 0, 1, 0,
            1, 1, 1, 1, 0,
            1, 0, 0, 0, 1,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] SmlA = { 
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 1, 1, 1, 1,
            1, 0, 0, 0, 1,
            1, 0, 0, 1, 1,
            0, 1, 1, 0, 1,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] CapB = { 
            1, 1, 1, 1, 0,
            1, 0, 0, 0, 1,
            1, 1, 1, 1, 0,
            1, 0, 0, 0, 1,
            1, 0, 0, 0, 1,
            1, 1, 1, 1, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] SmlB = { 
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            1, 1, 1, 1, 0,
            1, 0, 0, 0, 1,
            1, 0, 0, 0, 1,
            1, 1, 1, 1, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] CapC = { 
            0, 1, 1, 1, 1,
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            0, 1, 1, 1, 1,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] SmlC = { 
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 1, 1, 1, 0,
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            0, 1, 1, 1, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] CapD = { 
            1, 1, 1, 1, 0,
            1, 0, 0, 0, 1,
            1, 0, 0, 0, 1,
            1, 0, 0, 0, 1,
            1, 0, 0, 0, 1,
            1, 1, 1, 1, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] SmlD = { 
            0, 0, 0, 0, 1,
            0, 0, 0, 0, 1,
            0, 1, 1, 1, 1,
            1, 0, 0, 0, 1,
            1, 0, 0, 0, 1,
            0, 1, 1, 1, 1,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] CapE = { 
            1, 1, 1, 1, 1,
            1, 0, 0, 0, 0,
            1, 1, 1, 1, 0,
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            1, 1, 1, 1, 1,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] SmlE = { 
            0, 0, 0, 0, 0,
            0, 1, 1, 1, 0,
            1, 0, 0, 0, 1,
            1, 1, 1, 1, 0,
            1, 0, 0, 0, 0,
            0, 1, 1, 1, 1,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] CapF = { 
            1, 1, 1, 1, 1,
            1, 0, 0, 0, 0,
            1, 1, 1, 1, 0,
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] SmlF = { 
            0, 0, 0, 1, 1,
            0, 0, 1, 0, 0,
            0, 1, 1, 1, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] CapG = { 
            0, 1, 1, 1, 0,
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            1, 0, 1, 1, 1,
            1, 0, 0, 0, 1,
            0, 1, 1, 1, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] SmlG = { 
            0, 0, 0, 0, 0,
            0, 1, 1, 1, 0,
            1, 0, 0, 0, 1,
            1, 0, 0, 0, 1,
            1, 1, 1, 1, 0,
            1, 0, 0, 0, 0,
            1, 0, 1, 1, 0,
            1, 0, 0, 0, 1,
            0, 1, 1, 1, 0 };

        public static Byte[] CapH = { 
            1, 0, 0, 0, 1,
            1, 0, 0, 0, 1,
            1, 1, 1, 1, 1,
            1, 0, 0, 0, 1,
            1, 0, 0, 0, 1,
            1, 0, 0, 0, 1,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] SmlH = { 
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            1, 1, 1, 1, 0,
            1, 0, 0, 0, 1,
            1, 0, 0, 0, 1,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] CapI = { 
            1, 1, 1, 1, 1,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            1, 1, 1, 1, 1,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] SmlI = { 
            0, 0, 1, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] CapJ = { 
            0, 0, 0, 0, 1,
            0, 0, 0, 0, 1,
            0, 0, 0, 0, 1,
            0, 0, 0, 0, 1,
            1, 0, 0, 0, 1,
            0, 1, 1, 1, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] SmlJ = { 
            0, 0, 0, 1, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 1, 0,
            0, 0, 0, 1, 0,
            0, 1, 0, 1, 0,
            0, 0, 1, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] CapK = { 
            1, 0, 0, 1, 0,
            1, 0, 1, 0, 0,
            1, 1, 0, 0, 0,
            1, 0, 1, 0, 0,
            1, 0, 0, 1, 0,
            1, 0, 0, 1, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] SmlK = { 
            1, 0, 1, 0, 0,
            1, 0, 1, 0, 0,
            1, 1, 0, 0, 0,
            1, 0, 1, 0, 0,
            1, 0, 0, 1, 0,
            1, 0, 0, 1, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] CapL = { 
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            1, 1, 1, 1, 1,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] SmlL = { 
            0, 0, 0, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 0, 1, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] CapM = { 
            1, 0, 0, 0, 1,
            1, 1, 0, 1, 1,
            1, 0, 1, 0, 1,
            1, 0, 0, 0, 1,
            1, 0, 0, 0, 1,
            1, 0, 0, 0, 1,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] SmlM = { 
            0, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            1, 1, 0, 1, 0,
            1, 0, 1, 0, 1,
            1, 0, 1, 0, 1,
            1, 0, 1, 0, 1,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };
        //
        public static Byte[] CapN = {
        1, 1, 0, 0, 1,
        1, 0, 1, 0, 1,
        1, 0, 1, 0, 1,
        1, 0, 1, 0, 1,
        1, 0, 1, 0, 1,
        1, 0, 0, 1, 1,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] SmlN = {
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        1, 1, 1, 1, 0,
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] CapO = {
         0, 1, 1, 1, 0,
         1, 0, 0, 0, 1,
         1, 0, 0, 0, 1,
         1, 0, 0, 0, 1,
         1, 0, 0, 0, 1,
         0, 1, 1, 1, 0,
         0, 0, 0, 0, 0,
         0, 0, 0, 0, 0,
         0, 0, 0, 0, 0 };

        public static Byte[] SmlO = {
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 1, 1, 1, 0,
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        0, 1, 1, 1, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] CapP = {
        1, 1, 1, 1, 1,
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        1, 1, 1, 1, 0,
        1, 0, 0, 0, 0,
        1, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] SmlP = {
        0, 0, 0, 0, 0,
        1, 1, 1, 0, 0,
        1, 0, 0, 1, 0,
        1, 0, 0, 1, 0,
        1, 1, 1, 0, 0,
        1, 0, 0, 0, 0,
        1, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,};

        public static Byte[] CapQ = {
        1, 1, 1, 1, 0,
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        0, 1, 0, 1, 0,
        0, 0, 0, 1, 0,
        0, 0, 0, 1, 0,
        0, 0, 0, 0, 1,
        0, 0, 0, 0, 0 };

        public static Byte[] SmlQ = {
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 1, 1, 1, 0,
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        0, 1, 1, 1, 0,
        0, 0, 0, 1, 1,
        0, 0, 0, 0, 1,
        0, 0, 0, 0, 0 };

        public static Byte[] CapR = {
        0, 1, 1, 1, 0,
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        1, 1, 1, 1, 0,
        1, 0, 1, 0, 0,
        1, 0, 0, 1, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] SmlR = {
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 1, 1, 0, 0,
        1, 0, 0, 1, 0,
        1, 0, 0, 0, 0,
        1, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] CapS = {
        0, 1, 1, 1, 0,
        1, 0, 0, 0, 1,
        0, 1, 1, 1, 0,
        0, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        0, 1, 1, 1, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] SmlS = {
        0, 0, 0, 0, 0,
        0, 1, 1, 1, 1,
        1, 0, 0, 0, 0,
        0, 1, 1, 1, 0,
        0, 0, 0, 0, 1,
        1, 1, 1, 1, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] CapT = {
        0, 1, 1, 1, 0,
        1, 0, 1, 0, 1,
        0, 0, 1, 0, 0,
        0, 0, 1, 0, 0,
        0, 0, 1, 0, 0,
        0, 0, 1, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] SmlT = {
        0, 1, 0, 0, 0,
        1, 1, 1, 0, 0,
        0, 1, 0, 0, 0,
        0, 1, 0, 0, 0,
        0, 1, 0, 1, 0,
        0, 0, 1, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] CapU = {
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        0, 1, 1, 1, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] SmlU = {
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        0, 1, 1, 1, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] CapV = {
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        0, 1, 0, 1, 0,
        0, 0, 1, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] SmlV = {
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        0, 1, 0, 1, 0,
        0, 0, 1, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] CapW = {
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        1, 0, 1, 0, 1,
        1, 0, 1, 0, 1,
        1, 0, 1, 0, 1,
        0, 1, 0, 1, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] SmlW = {
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        1, 0, 1, 0, 1,
        1, 0, 1, 0, 1,
        1, 0, 1, 0, 1,
        0, 1, 0, 1, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] CapX = {
        1, 0, 0, 0, 1,
        0, 1, 0, 1, 0,
        0, 0, 1, 0, 0,
        0, 0, 1, 0, 0,
        0, 1, 0, 1, 0,
        1, 0, 0, 0, 1,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] SmlX = {
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        1, 1, 0, 1, 1,
        0, 0, 1, 1, 0,
        0, 0, 1, 0, 0,
        1, 1, 0, 1, 1,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] CapY = {
        1, 0, 0, 0, 1,
        0, 1, 0, 1, 0,
        0, 0, 1, 0, 0,
        0, 0, 1, 0, 0,
        0, 0, 1, 0, 0,
        0, 0, 1, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] SmlY = {
        1, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        0, 1, 0, 0, 1,
        0, 0, 1, 1, 1,
        0, 0, 0, 0, 1,
        1, 0, 0, 0, 1,
        0, 1, 1, 1, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] CapZ = {
        1, 1, 1, 1, 1,
        0, 0, 0, 1, 0,
        0, 0, 1, 0, 0,
        0, 1, 0, 0, 0,
        1, 0, 0, 0, 0,
        1, 1, 1, 1, 1,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] SmlZ = {
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        1, 1, 1, 1, 1,
        0, 0, 0, 1, 0,
        0, 0, 1, 0, 0,
        1, 1, 1, 1, 1,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0,
        0, 0, 0, 0, 0 };

        public static Byte[] Null = { 
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] Zero = { 0, 1, 1, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 0, 1, 1, 1, 0, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static Byte[] One = { 
            0, 1, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 1, 1, 1, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] Two = { 
            0, 1, 1, 1, 0,
            1, 0, 0, 0, 1,
            0, 0, 0, 1, 0,
            0, 0, 1, 0, 0,
            0, 1, 0, 0, 0,
            1, 1, 1, 1, 1,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] Three = { 
            0, 1, 1, 1, 0,
            1, 0, 0, 0, 1,
            0, 0, 1, 1, 0,
            0, 0, 0, 0, 1,
            1, 0, 0, 0, 1,
            0, 1, 1, 1, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] Four = { 
            0, 0, 0, 1, 0,
            0, 0, 1, 1, 0,
            0, 1, 0, 1, 0,
            1, 0, 0, 1, 0,
            1, 1, 1, 1, 1,
            0, 0, 0, 1, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] Five = { 
            1, 1, 1, 1, 1,
            1, 0, 0, 0, 0,
            1, 1, 1, 1, 0,
            0, 0, 0, 0, 1,
            0, 0, 0, 0, 1,
            1, 1, 1, 1, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] Six = { 
            0, 1, 1, 1, 0,
            1, 0, 0, 0, 0,
            1, 0, 1, 1, 0,
            1, 1, 0, 0, 1,
            1, 0, 0, 0, 1,
            0, 1, 1, 1, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] Seven = { 
            1, 1, 1, 1, 1,
            0, 0, 0, 0, 1,
            0, 0, 0, 1, 0,
            0, 0, 1, 0, 0,
            0, 1, 0, 0, 0,
            1, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] slash = {
            0, 0, 0, 0, 1,
            0, 0, 0, 0, 1,
            0, 0, 0, 1, 0,
            0, 0, 0, 1, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 1, 0, 0, 0,
            0, 1, 0, 0, 0,
            1, 0, 0, 0, 0 };

        public static Byte[] neslash = {
            1, 0, 0, 0, 0,
            1, 0, 0, 0, 0,
            0, 1, 0, 0, 0,
            0, 1, 0, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 0, 1, 0,
            0, 0, 0, 1, 0,
            0, 0, 0, 0, 1 };

        public static Byte[] palka = {
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0 };

        public static Byte[] plus = {
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            1, 1, 1, 1, 1,
            0, 0, 1, 0, 0,
            0, 0, 1, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] ravno = {
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            1, 1, 1, 1, 1,
            0, 0, 0, 0, 0,
            1, 1, 1, 1, 1,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0,
            0, 0, 0, 0, 0 };

        public static Byte[] Eight = { 0, 1, 1, 1, 0, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static Byte[] Nine = { 0, 1, 1, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 1, 1, 0, 1, 1, 0, 1, 0, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public static Byte[] Colon = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        #endregion
    }
    public static class Otrisovka
    {
        public static void DrawChar(int x, int y, byte[] Data, int Color)
        {
            int c = 0;
            for (int p = y; p < y + 9; p++)
            {
                for (int i = x; i < x + 5; i++)
                {
                    if (Data[c] == 1)
                    {
                        scr.SetPixel(i, p, Color);
                    }

                    c = c + 1;
                }
            }
        }
        public static void Write(String Text, int Textx, int Texty, System.Drawing.Color colora, int Color = 255, bool NTDF = false)
        {
            int iznx = Textx;
            //FOR VGA WRITER
            if (NTDF == true) {
                foreach (char a in Text)
                {
                    if (a == 'A')
                    {
                        DrawChar(Textx, Texty, Font8x8.CapA, Color);
                        Textx += 6;
                    }
                    else if (a == 'a')
                    {
                        DrawChar(Textx, Texty, Font8x8.SmlA, Color);
                        Textx += 6;
                    }
                    else if (a == 'B')
                    {
                        DrawChar(Textx, Texty, Font8x8.CapB, Color);
                        Textx += 6;
                    }
                    else if (a == 'b')
                    {
                        DrawChar(Textx, Texty, Font8x8.SmlB, Color);
                        Textx += 6;
                    }
                    else if (a == 'C')
                    {
                        DrawChar(Textx, Texty, Font8x8.CapC, Color);
                        Textx += 6;
                    }
                    else if (a == 'c')
                    {
                        DrawChar(Textx, Texty, Font8x8.SmlC, Color);
                        Textx += 6;
                    }
                    else if (a == 'D')
                    {
                        DrawChar(Textx, Texty, Font8x8.CapD, Color);
                        Textx += 6;
                    }
                    else if (a == 'd')
                    {
                        DrawChar(Textx, Texty, Font8x8.SmlD, Color);
                        Textx += 6;
                    }

                    else if (a == 'E')
                    {
                        DrawChar(Textx, Texty, Font8x8.CapE, Color);
                        Textx += 6;
                    }
                    else if (a == 'e')
                    {
                        DrawChar(Textx, Texty, Font8x8.SmlE, Color);
                        Textx += 6;
                    }
                    else if (a == 'F')
                    {
                        DrawChar(Textx, Texty, Font8x8.CapF, Color);
                        Textx += 6;
                    }
                    else if (a == 'f')
                    {
                        DrawChar(Textx, Texty, Font8x8.SmlF, Color);
                        Textx += 6;
                    }
                    else if (a == 'G')
                    {
                        DrawChar(Textx, Texty, Font8x8.CapG, Color);
                        Textx += 6;
                    }
                    else if (a == 'g')
                    {
                        DrawChar(Textx, Texty, Font8x8.SmlG, Color);
                        Textx += 6;
                    }
                    else if (a == 'H')
                    {
                        DrawChar(Textx, Texty, Font8x8.CapH, Color);
                        Textx += 6;
                    }
                    else if (a == 'h')
                    {
                        DrawChar(Textx, Texty, Font8x8.SmlH, Color);
                        Textx += 6;
                    }
                    else if (a == 'I')
                    {
                        DrawChar(Textx, Texty, Font8x8.CapI, Color);
                        Textx += 6;
                    }
                    else if (a == 'i')
                    {
                        DrawChar(Textx, Texty, Font8x8.SmlI, Color);
                        Textx += 6;
                    }
                    else if (a == 'J')
                    {
                        DrawChar(Textx, Texty, Font8x8.CapJ, Color);
                        Textx += 6;
                    }
                    else if (a == 'j')
                    {
                        DrawChar(Textx, Texty, Font8x8.SmlJ, Color);
                        Textx += 6;
                    }

                    else if (a == 'K')
                    {
                        DrawChar(Textx, Texty, Font8x8.CapK, Color);
                        Textx += 6;
                    }
                    else if (a == 'k')
                    {
                        DrawChar(Textx, Texty, Font8x8.SmlK, Color);
                        Textx += 6;
                    }
                    else if (a == 'L')
                    {
                        DrawChar(Textx, Texty, Font8x8.CapL, Color);
                        Textx += 6;
                    }
                    else if (a == 'l')
                    {
                        DrawChar(Textx, Texty, Font8x8.SmlL, Color);
                        Textx += 6;
                    }
                    else if (a == 'M')
                    {
                        DrawChar(Textx, Texty, Font8x8.CapM, Color);
                        Textx += 6;
                    }
                    else if (a == 'm')
                    {
                        DrawChar(Textx, Texty, Font8x8.SmlM, Color);
                        Textx += 6;
                    }
                    else if (a == 'N')
                    {
                        DrawChar(Textx, Texty, Font8x8.CapN, Color);
                        Textx += 6;
                    }
                    else if (a == 'n')
                    {
                        DrawChar(Textx, Texty, Font8x8.SmlN, Color);
                        Textx += 6;
                    }
                    else if (a == 'O')
                    {
                        DrawChar(Textx, Texty, Font8x8.CapO, Color);
                        Textx += 6;
                    }
                    else if (a == 'o')
                    {
                        DrawChar(Textx, Texty, Font8x8.SmlO, Color);
                        Textx += 6;
                    }
                    else if (a == 'P')
                    {
                        DrawChar(Textx, Texty, Font8x8.CapP, Color);
                        Textx += 6;
                    }
                    else if (a == 'p')
                    {
                        DrawChar(Textx, Texty, Font8x8.SmlP, Color);
                        Textx += 6;
                    }

                    else if (a == 'Q')
                    {
                        DrawChar(Textx, Texty, Font8x8.CapQ, Color);
                        Textx += 6;
                    }
                    else if (a == 'q')
                    {
                        DrawChar(Textx, Texty, Font8x8.SmlQ, Color);
                        Textx += 6;
                    }
                    else if (a == 'R')
                    {
                        DrawChar(Textx, Texty, Font8x8.CapR, Color);
                        Textx += 6;
                    }
                    else if (a == 'r')
                    {
                        DrawChar(Textx, Texty, Font8x8.SmlR, Color);
                        Textx += 6;
                    }
                    else if (a == 'S')
                    {
                        DrawChar(Textx, Texty, Font8x8.CapS, Color);
                        Textx += 6;
                    }
                    else if (a == 's')
                    {
                        DrawChar(Textx, Texty, Font8x8.SmlS, Color);
                        Textx += 6;
                    }
                    else if (a == 'T')
                    {
                        DrawChar(Textx, Texty, Font8x8.CapT, Color);
                        Textx += 6;
                    }
                    else if (a == 't')
                    {
                        DrawChar(Textx, Texty, Font8x8.SmlT, Color);
                        Textx += 6;
                    }
                    else if (a == 'U')
                    {
                        DrawChar(Textx, Texty, Font8x8.CapU, Color);
                        Textx += 6;
                    }
                    else if (a == 'u')
                    {
                        DrawChar(Textx, Texty, Font8x8.SmlU, Color);
                        Textx += 6;
                    }
                    else if (a == 'V')
                    {
                        DrawChar(Textx, Texty, Font8x8.CapV, Color);
                        Textx += 6;
                    }
                    else if (a == 'v')
                    {
                        DrawChar(Textx, Texty, Font8x8.SmlV, Color);
                        Textx += 6;
                    }

                    else if (a == 'W')
                    {
                        DrawChar(Textx, Texty, Font8x8.CapW, Color);
                        Textx += 6;
                    }
                    else if (a == 'w')
                    {
                        DrawChar(Textx, Texty, Font8x8.SmlW, Color);
                        Textx += 6;
                    }
                    else if (a == 'X')
                    {
                        DrawChar(Textx, Texty, Font8x8.CapX, Color);
                        Textx += 6;
                    }
                    else if (a == 'x')
                    {
                        DrawChar(Textx, Texty, Font8x8.SmlX, Color);
                        Textx += 6;
                    }
                    else if (a == 'Y')
                    {
                        DrawChar(Textx, Texty, Font8x8.CapY, Color);
                        Textx += 6;
                    }
                    else if (a == 'y')
                    {
                        DrawChar(Textx, Texty, Font8x8.SmlY, Color);
                        Textx += 6;
                    }
                    else if (a == 'Z')
                    {
                        DrawChar(Textx, Texty, Font8x8.CapZ, Color);
                        Textx += 6;
                    }
                    else if (a == 'z')
                    {
                        DrawChar(Textx, Texty, Font8x8.SmlZ, Color);
                        Textx += 6;
                    }
                    else if (a == '.')
                    {
                        DrawChar(Textx, Texty, Font8x8.Dote, Color);
                        Textx += 6;
                    }
                    else if (a == '!')
                    {
                        DrawChar(Textx, Texty, Font8x8.Utro, Color);
                        Textx += 6;
                    }
                    else if (a == ' ')
                    {
                        DrawChar(Textx, Texty, Font8x8.Null, Color);
                        Textx += 6;
                    }
                    else if (a == '0')
                    {
                        DrawChar(Textx, Texty, Font8x8.Zero, Color);
                        Textx += 6;
                    }
                    else if (a == '1')
                    {
                        DrawChar(Textx, Texty, Font8x8.One, Color);
                        Textx += 6;
                    }
                    else if (a == '2')
                    {
                        DrawChar(Textx, Texty, Font8x8.Two, Color);
                        Textx += 6;
                    }
                    else if (a == '3')
                    {
                        DrawChar(Textx, Texty, Font8x8.Three, Color);
                        Textx += 6;
                    }
                    else if (a == '4')
                    {
                        DrawChar(Textx, Texty, Font8x8.Four, Color);
                        Textx += 6;
                    }
                    else if (a == '5')
                    {
                        DrawChar(Textx, Texty, Font8x8.Five, Color);
                        Textx += 6;
                    }
                    else if (a == '6')
                    {
                        DrawChar(Textx, Texty, Font8x8.Six, Color);
                        Textx += 6;
                    }
                    else if (a == '7')
                    {
                        DrawChar(Textx, Texty, Font8x8.Seven, Color);
                        Textx += 6;
                    }
                    else if (a == '8')
                    {
                        DrawChar(Textx, Texty, Font8x8.Eight, Color);
                        Textx += 6;
                    }
                    else if (a == '9')
                    {
                        DrawChar(Textx, Texty, Font8x8.Nine, Color);
                        Textx += 6;
                    }
                    else if (a == ':')
                    {
                        DrawChar(Textx, Texty, Font8x8.Colon, Color);
                        Textx += 6;
                    }
                    else if (a == '[')
                    {
                        DrawChar(Textx, Texty, Font8x8.Fill, Color);
                        Textx += 6;
                    }
                    else if (a == ']')
                    {
                        DrawChar(Textx, Texty, Font8x8.NotF, Color);
                        Textx += 6;
                    }
                    else if (a == '_')
                    {
                        DrawChar(Textx, Texty, Font8x8.loll, Color);
                        Textx += 6;
                    }
                    else if (a == '-')
                    {
                        DrawChar(Textx, Texty, Font8x8.defis, Color);
                        Textx = Textx + 4;
                    }
                    else if (a == '|')
                    {
                        DrawChar(Textx, Texty, Font8x8.palka, Color);
                        Textx += 6;
                    }
                    else if (a == '/')
                    {
                        DrawChar(Textx, Texty, Font8x8.slash, Color);
                        Textx += 6;
                    }
                    else if (a == '\\')
                    {
                        DrawChar(Textx, Texty, Font8x8.neslash, Color);
                        Textx += 6;
                    }
                    else if (a == '=')
                    {
                        DrawChar(Textx, Texty, Font8x8.ravno, Color);
                        Textx += 6;
                    }
                    else if (a == '+')
                    {
                        DrawChar(Textx, Texty, Font8x8.plus, Color);
                        Textx += 6;
                    }
                    else if (a == '%')
                    {
                        DrawChar(Textx, Texty, Font8x8.procent, Color);
                        Textx += 6;
                    }
                    else if (a == '@')
                    {
                        DrawChar(Textx, Texty, Font8x8.sobaka, Color);
                        Textx += 6;
                    }
                    else if (a == '?')
                    {
                        DrawChar(Textx, Texty, Font8x8.vopros, Color);
                        Textx += 6;
                    }
                    else if (a == '#')
                    {
                        DrawChar(Textx, Texty, Font8x8.resh, Color);
                        Textx += 6;
                    }
                    else if (a == '$')
                    {
                        DrawChar(Textx, Texty, Font8x8.dollar, Color);
                        Textx += 6;
                    }
                    else if (a == '^')
                    {
                        DrawChar(Textx, Texty, Font8x8.xyi, Color);
                        Textx += 6;
                    }
                    else if (a == '&')
                    {
                        DrawChar(Textx, Texty, Font8x8.andd, Color);
                        Textx += 6;
                    }
                    else if (a == '*')
                    {
                        DrawChar(Textx, Texty, Font8x8.zvezda, Color);
                        Textx += 6;
                    }
                    else if (a == '(')
                    {
                        DrawChar(Textx, Texty, Font8x8.Sopen, Color);
                        Textx += 6;
                    }
                    else if (a == ')')
                    {
                        DrawChar(Textx, Texty, Font8x8.Sclose, Color);
                        Textx += 6;
                    }
                    else if (a == '\'')
                    {
                        DrawChar(Textx, Texty, Font8x8.kov, Color);
                        Textx += 6;
                    }
                    else if (a == ',')
                    {
                        DrawChar(Textx, Texty, Font8x8.zapapa, Color);
                        Textx += 6;
                    }
                    else if (a == '`')
                    {
                        //DrawChar(Textx, Texty, Font8x8.nul, Color);
                        Textx = iznx;
                        Texty += 11;
                    }
                }
            }
            else
            {
                Hattory.Kernel.canvas.DrawString(Text, Cosmos.System.Graphics.Fonts.PCScreenFont.Default, colora, Textx, Texty);
            }
        }
    }        
}
