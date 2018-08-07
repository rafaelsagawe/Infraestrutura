/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package ni.semed.ieducaralimentacao;

import java.beans.PropertyChangeListener;
import java.beans.PropertyChangeSupport;
import java.io.Serializable;
import javax.persistence.Basic;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.Table;
import javax.persistence.Transient;

/**
 *
 * @author Rafael Sagawe Favero
 */
@Entity
@Table(name = "cliente", catalog = "ieducar", schema = "alimentos")
@NamedQueries({
    @NamedQuery(name = "Cliente.findAll", query = "SELECT c FROM Cliente c")
    , @NamedQuery(name = "Cliente.findByIdcli", query = "SELECT c FROM Cliente c WHERE c.idcli = :idcli")
    , @NamedQuery(name = "Cliente.findByNome", query = "SELECT c FROM Cliente c WHERE c.nome = :nome")
    , @NamedQuery(name = "Cliente.findByCnpj", query = "SELECT c FROM Cliente c WHERE c.cnpj = :cnpj")
    , @NamedQuery(name = "Cliente.findByEndereco", query = "SELECT c FROM Cliente c WHERE c.endereco = :endereco")
    , @NamedQuery(name = "Cliente.findByBairro", query = "SELECT c FROM Cliente c WHERE c.bairro = :bairro")
    , @NamedQuery(name = "Cliente.findByCidade", query = "SELECT c FROM Cliente c WHERE c.cidade = :cidade")
    , @NamedQuery(name = "Cliente.findByCep", query = "SELECT c FROM Cliente c WHERE c.cep = :cep")
    , @NamedQuery(name = "Cliente.findByUf", query = "SELECT c FROM Cliente c WHERE c.uf = :uf")
    , @NamedQuery(name = "Cliente.findByTelefone", query = "SELECT c FROM Cliente c WHERE c.telefone = :telefone")
    , @NamedQuery(name = "Cliente.findByFax", query = "SELECT c FROM Cliente c WHERE c.fax = :fax")
    , @NamedQuery(name = "Cliente.findByEmail", query = "SELECT c FROM Cliente c WHERE c.email = :email")
    , @NamedQuery(name = "Cliente.findByPrefeito", query = "SELECT c FROM Cliente c WHERE c.prefeito = :prefeito")
    , @NamedQuery(name = "Cliente.findByEducacao", query = "SELECT c FROM Cliente c WHERE c.educacao = :educacao")
    , @NamedQuery(name = "Cliente.findByAdministracao", query = "SELECT c FROM Cliente c WHERE c.administracao = :administracao")
    , @NamedQuery(name = "Cliente.findByCoordenacao", query = "SELECT c FROM Cliente c WHERE c.coordenacao = :coordenacao")
    , @NamedQuery(name = "Cliente.findByInscritos", query = "SELECT c FROM Cliente c WHERE c.inscritos = :inscritos")
    , @NamedQuery(name = "Cliente.findByIdpes", query = "SELECT c FROM Cliente c WHERE c.idpes = :idpes")
    , @NamedQuery(name = "Cliente.findByIdentificacao", query = "SELECT c FROM Cliente c WHERE c.identificacao = :identificacao")
    , @NamedQuery(name = "Cliente.findByTabProdutos", query = "SELECT c FROM Cliente c WHERE c.tabProdutos = :tabProdutos")})
public class Cliente implements Serializable {

    @Transient
    private PropertyChangeSupport changeSupport = new PropertyChangeSupport(this);

    private static final long serialVersionUID = 1L;
    @Id
    @Basic(optional = false)
    @Column(name = "idcli")
    private String idcli;
    @Basic(optional = false)
    @Column(name = "nome")
    private String nome;
    @Basic(optional = false)
    @Column(name = "cnpj")
    private String cnpj;
    @Basic(optional = false)
    @Column(name = "endereco")
    private String endereco;
    @Basic(optional = false)
    @Column(name = "bairro")
    private String bairro;
    @Basic(optional = false)
    @Column(name = "cidade")
    private String cidade;
    @Column(name = "cep")
    private String cep;
    @Basic(optional = false)
    @Column(name = "uf")
    private String uf;
    @Basic(optional = false)
    @Column(name = "telefone")
    private String telefone;
    @Column(name = "fax")
    private String fax;
    @Column(name = "email")
    private String email;
    @Basic(optional = false)
    @Column(name = "prefeito")
    private String prefeito;
    @Basic(optional = false)
    @Column(name = "educacao")
    private String educacao;
    @Basic(optional = false)
    @Column(name = "administracao")
    private String administracao;
    @Basic(optional = false)
    @Column(name = "coordenacao")
    private String coordenacao;
    @Basic(optional = false)
    @Column(name = "inscritos")
    private Character inscritos;
    @Basic(optional = false)
    @Column(name = "idpes")
    private int idpes;
    @Basic(optional = false)
    @Column(name = "identificacao")
    private String identificacao;
    @Column(name = "tab_produtos")
    private Character tabProdutos;

    public Cliente() {
    }

    public Cliente(String idcli) {
        this.idcli = idcli;
    }

    public Cliente(String idcli, String nome, String cnpj, String endereco, String bairro, String cidade, String uf, String telefone, String prefeito, String educacao, String administracao, String coordenacao, Character inscritos, int idpes, String identificacao) {
        this.idcli = idcli;
        this.nome = nome;
        this.cnpj = cnpj;
        this.endereco = endereco;
        this.bairro = bairro;
        this.cidade = cidade;
        this.uf = uf;
        this.telefone = telefone;
        this.prefeito = prefeito;
        this.educacao = educacao;
        this.administracao = administracao;
        this.coordenacao = coordenacao;
        this.inscritos = inscritos;
        this.idpes = idpes;
        this.identificacao = identificacao;
    }

    public String getIdcli() {
        return idcli;
    }

    public void setIdcli(String idcli) {
        String oldIdcli = this.idcli;
        this.idcli = idcli;
        changeSupport.firePropertyChange("idcli", oldIdcli, idcli);
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        String oldNome = this.nome;
        this.nome = nome;
        changeSupport.firePropertyChange("nome", oldNome, nome);
    }

    public String getCnpj() {
        return cnpj;
    }

    public void setCnpj(String cnpj) {
        String oldCnpj = this.cnpj;
        this.cnpj = cnpj;
        changeSupport.firePropertyChange("cnpj", oldCnpj, cnpj);
    }

    public String getEndereco() {
        return endereco;
    }

    public void setEndereco(String endereco) {
        String oldEndereco = this.endereco;
        this.endereco = endereco;
        changeSupport.firePropertyChange("endereco", oldEndereco, endereco);
    }

    public String getBairro() {
        return bairro;
    }

    public void setBairro(String bairro) {
        String oldBairro = this.bairro;
        this.bairro = bairro;
        changeSupport.firePropertyChange("bairro", oldBairro, bairro);
    }

    public String getCidade() {
        return cidade;
    }

    public void setCidade(String cidade) {
        String oldCidade = this.cidade;
        this.cidade = cidade;
        changeSupport.firePropertyChange("cidade", oldCidade, cidade);
    }

    public String getCep() {
        return cep;
    }

    public void setCep(String cep) {
        String oldCep = this.cep;
        this.cep = cep;
        changeSupport.firePropertyChange("cep", oldCep, cep);
    }

    public String getUf() {
        return uf;
    }

    public void setUf(String uf) {
        String oldUf = this.uf;
        this.uf = uf;
        changeSupport.firePropertyChange("uf", oldUf, uf);
    }

    public String getTelefone() {
        return telefone;
    }

    public void setTelefone(String telefone) {
        String oldTelefone = this.telefone;
        this.telefone = telefone;
        changeSupport.firePropertyChange("telefone", oldTelefone, telefone);
    }

    public String getFax() {
        return fax;
    }

    public void setFax(String fax) {
        String oldFax = this.fax;
        this.fax = fax;
        changeSupport.firePropertyChange("fax", oldFax, fax);
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        String oldEmail = this.email;
        this.email = email;
        changeSupport.firePropertyChange("email", oldEmail, email);
    }

    public String getPrefeito() {
        return prefeito;
    }

    public void setPrefeito(String prefeito) {
        String oldPrefeito = this.prefeito;
        this.prefeito = prefeito;
        changeSupport.firePropertyChange("prefeito", oldPrefeito, prefeito);
    }

    public String getEducacao() {
        return educacao;
    }

    public void setEducacao(String educacao) {
        String oldEducacao = this.educacao;
        this.educacao = educacao;
        changeSupport.firePropertyChange("educacao", oldEducacao, educacao);
    }

    public String getAdministracao() {
        return administracao;
    }

    public void setAdministracao(String administracao) {
        String oldAdministracao = this.administracao;
        this.administracao = administracao;
        changeSupport.firePropertyChange("administracao", oldAdministracao, administracao);
    }

    public String getCoordenacao() {
        return coordenacao;
    }

    public void setCoordenacao(String coordenacao) {
        String oldCoordenacao = this.coordenacao;
        this.coordenacao = coordenacao;
        changeSupport.firePropertyChange("coordenacao", oldCoordenacao, coordenacao);
    }

    public Character getInscritos() {
        return inscritos;
    }

    public void setInscritos(Character inscritos) {
        Character oldInscritos = this.inscritos;
        this.inscritos = inscritos;
        changeSupport.firePropertyChange("inscritos", oldInscritos, inscritos);
    }

    public int getIdpes() {
        return idpes;
    }

    public void setIdpes(int idpes) {
        int oldIdpes = this.idpes;
        this.idpes = idpes;
        changeSupport.firePropertyChange("idpes", oldIdpes, idpes);
    }

    public String getIdentificacao() {
        return identificacao;
    }

    public void setIdentificacao(String identificacao) {
        String oldIdentificacao = this.identificacao;
        this.identificacao = identificacao;
        changeSupport.firePropertyChange("identificacao", oldIdentificacao, identificacao);
    }

    public Character getTabProdutos() {
        return tabProdutos;
    }

    public void setTabProdutos(Character tabProdutos) {
        Character oldTabProdutos = this.tabProdutos;
        this.tabProdutos = tabProdutos;
        changeSupport.firePropertyChange("tabProdutos", oldTabProdutos, tabProdutos);
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (idcli != null ? idcli.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Cliente)) {
            return false;
        }
        Cliente other = (Cliente) object;
        if ((this.idcli == null && other.idcli != null) || (this.idcli != null && !this.idcli.equals(other.idcli))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "ni.semed.ieducaralimentacao.Cliente[ idcli=" + idcli + " ]";
    }

    public void addPropertyChangeListener(PropertyChangeListener listener) {
        changeSupport.addPropertyChangeListener(listener);
    }

    public void removePropertyChangeListener(PropertyChangeListener listener) {
        changeSupport.removePropertyChangeListener(listener);
    }

}
