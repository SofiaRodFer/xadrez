using System;

namespace tabuleiro
{
    class TabuleiroException : Exception
    {
        public TabuleiroException(string msg) : base(msg + " Pressione 'Enter' para continuar.") {}
    }
}
