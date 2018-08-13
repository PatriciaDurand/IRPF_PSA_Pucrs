using System;
using System.Collections.Generic;
using System.Text;

namespace Irpf.BLL
{
    public interface ContribuinteDAO
    {
        void inserir(Contribuinte c); //throws CpfDuplicadoException, DAOException;
        void alterar(Contribuinte c); //throws CpfInexistenteException, DAOException;
        Contribuinte buscar(String cpf); //throws DAOException;
        List<Contribuinte> buscarIdosos(); //throws DAOException;
        List<Contribuinte> buscarTodos(); //throws DAOException;
    }
}
