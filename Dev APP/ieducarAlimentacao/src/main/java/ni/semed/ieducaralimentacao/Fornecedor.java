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
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
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
@Table(name = "fornecedor", catalog = "ieducar", schema = "alimentos")
@NamedQueries({
    @NamedQuery(name = "Fornecedor.findAll", query = "SELECT f FROM Fornecedor f")
    , @NamedQuery(name = "Fornecedor.findByIdfor", query = "SELECT f FROM Fornecedor f WHERE f.idfor = :idfor")
    , @NamedQuery(name = "Fornecedor.findByIdpes", query = "SELECT f FROM Fornecedor f WHERE f.idpes = :idpes")
    , @NamedQuery(name = "Fornecedor.findByIdcli", query = "SELECT f FROM Fornecedor f WHERE f.idcli = :idcli")
    , @NamedQuery(name = "Fornecedor.findByRazaoSocial", query = "SELECT f FROM Fornecedor f WHERE f.razaoSocial = :razaoSocial")
    , @NamedQuery(name = "Fornecedor.findByNomeFantasia", query = "SELECT f FROM Fornecedor f WHERE f.nomeFantasia = :nomeFantasia")
    , @NamedQuery(name = "Fornecedor.findByEndereco", query = "SELECT f FROM Fornecedor f WHERE f.endereco = :endereco")
    , @NamedQuery(name = "Fornecedor.findByComplemento", query = "SELECT f FROM Fornecedor f WHERE f.complemento = :complemento")
    , @NamedQuery(name = "Fornecedor.findByBairro", query = "SELECT f FROM Fornecedor f WHERE f.bairro = :bairro")
    , @NamedQuery(name = "Fornecedor.findByCep", query = "SELECT f FROM Fornecedor f WHERE f.cep = :cep")
    , @NamedQuery(name = "Fornecedor.findByCidade", query = "SELECT f FROM Fornecedor f WHERE f.cidade = :cidade")
    , @NamedQuery(name = "Fornecedor.findByUf", query = "SELECT f FROM Fornecedor f WHERE f.uf = :uf")
    , @NamedQuery(name = "Fornecedor.findByTelefone", query = "SELECT f FROM Fornecedor f WHERE f.telefone = :telefone")
    , @NamedQuery(name = "Fornecedor.findByFax", query = "SELECT f FROM Fornecedor f WHERE f.fax = :fax")
    , @NamedQuery(name = "Fornecedor.findByEmail", query = "SELECT f FROM Fornecedor f WHERE f.email = :email")
    , @NamedQuery(name = "Fornecedor.findByContato", query = "SELECT f FROM Fornecedor f WHERE f.contato = :contato")
    , @NamedQuery(name = "Fornecedor.findByCpfCnpj", query = "SELECT f FROM Fornecedor f WHERE f.cpfCnpj = :cpfCnpj")
    , @NamedQuery(name = "Fornecedor.findByInscrEstadual", query = "SELECT f FROM Fornecedor f WHERE f.inscrEstadual = :inscrEstadual")
    , @NamedQuery(name = "Fornecedor.findByInscrMunicipal", query = "SELECT f FROM Fornecedor f WHERE f.inscrMunicipal = :inscrMunicipal")
    , @NamedQuery(name = "Fornecedor.findByTipo", query = "SELECT f FROM Fornecedor f WHERE f.tipo = :tipo")})
public class Fornecedor implements Serializable {

    @Transient
    private PropertyChangeSupport changeSupport = new PropertyChangeSupport(this);

    private static final long serialVersionUID = 1L;
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Basic(optional = false)
    @Column(name = "idfor")
    private Integer idfor;
    @Basic(optional = false)
    @Column(name = "idpes")
    private int idpes;
    @Basic(optional = false)
    @Column(name = "idcli")
    private String idcli;
    @Basic(optional = false)
    @Column(name = "razao_social")
    private String razaoSocial;
    @Basic(optional = false)
    @Column(name = "nome_fantasia")
    private String nomeFantasia;
    @Basic(optional = false)
    @Column(name = "endereco")
    private String endereco;
    @Column(name = "complemento")
    private String complemento;
    @Basic(optional = false)
    @Column(name = "bairro")
    private String bairro;
    @Column(name = "cep")
    private String cep;
    @Basic(optional = false)
    @Column(name = "cidade")
    private String cidade;
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
    @Column(name = "contato")
    private String contato;
    @Basic(optional = false)
    @Column(name = "cpf_cnpj")
    private String cpfCnpj;
    @Column(name = "inscr_estadual")
    private String inscrEstadual;
    @Column(name = "inscr_municipal")
    private String inscrMunicipal;
    @Basic(optional = false)
    @Column(name = "tipo")
    private Character tipo;

    public Fornecedor() {
    }

    public Fornecedor(Integer idfor) {
        this.idfor = idfor;
    }

    public Fornecedor(Integer idfor, int idpes, String idcli, String razaoSocial, String nomeFantasia, String endereco, String bairro, String cidade, String uf, String telefone, String contato, String cpfCnpj, Character tipo) {
        this.idfor = idfor;
        this.idpes = idpes;
        this.idcli = idcli;
        this.razaoSocial = razaoSocial;
        this.nomeFantasia = nomeFantasia;
        this.endereco = endereco;
        this.bairro = bairro;
        this.cidade = cidade;
        this.uf = uf;
        this.telefone = telefone;
        this.contato = contato;
        this.cpfCnpj = cpfCnpj;
        this.tipo = tipo;
    }

    public Integer getIdfor() {
        return idfor;
    }

    public void setIdfor(Integer idfor) {
        Integer oldIdfor = this.idfor;
        this.idfor = idfor;
        changeSupport.firePropertyChange("idfor", oldIdfor, idfor);
    }

    public int getIdpes() {
        return idpes;
    }

    public void setIdpes(int idpes) {
        int oldIdpes = this.idpes;
        this.idpes = idpes;
        changeSupport.firePropertyChange("idpes", oldIdpes, idpes);
    }

    public String getIdcli() {
        return idcli;
    }

    public void setIdcli(String idcli) {
        String oldIdcli = this.idcli;
        this.idcli = idcli;
        changeSupport.firePropertyChange("idcli", oldIdcli, idcli);
    }

    public String getRazaoSocial() {
        return razaoSocial;
    }

    public void setRazaoSocial(String razaoSocial) {
        String oldRazaoSocial = this.razaoSocial;
        this.razaoSocial = razaoSocial;
        changeSupport.firePropertyChange("razaoSocial", oldRazaoSocial, razaoSocial);
    }

    public String getNomeFantasia() {
        return nomeFantasia;
    }

    public void setNomeFantasia(String nomeFantasia) {
        String oldNomeFantasia = this.nomeFantasia;
        this.nomeFantasia = nomeFantasia;
        changeSupport.firePropertyChange("nomeFantasia", oldNomeFantasia, nomeFantasia);
    }

    public String getEndereco() {
        return endereco;
    }

    public void setEndereco(String endereco) {
        String oldEndereco = this.endereco;
        this.endereco = endereco;
        changeSupport.firePropertyChange("endereco", oldEndereco, endereco);
    }

    public String getComplemento() {
        return complemento;
    }

    public void setComplemento(String complemento) {
        String oldComplemento = this.complemento;
        this.complemento = complemento;
        changeSupport.firePropertyChange("complemento", oldComplemento, complemento);
    }

    public String getBairro() {
        return bairro;
    }

    public void setBairro(String bairro) {
        String oldBairro = this.bairro;
        this.bairro = bairro;
        changeSupport.firePropertyChange("bairro", oldBairro, bairro);
    }

    public String getCep() {
        return cep;
    }

    public void setCep(String cep) {
        String oldCep = this.cep;
        this.cep = cep;
        changeSupport.firePropertyChange("cep", oldCep, cep);
    }

    public String getCidade() {
        return cidade;
    }

    public void setCidade(String cidade) {
        String oldCidade = this.cidade;
        this.cidade = cidade;
        changeSupport.firePropertyChange("cidade", oldCidade, cidade);
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

    public String getContato() {
        return contato;
    }

    public void setContato(String contato) {
        String oldContato = this.contato;
        this.contato = contato;
        changeSupport.firePropertyChange("contato", oldContato, contato);
    }

    public String getCpfCnpj() {
        return cpfCnpj;
    }

    public void setCpfCnpj(String cpfCnpj) {
        String oldCpfCnpj = this.cpfCnpj;
        this.cpfCnpj = cpfCnpj;
        changeSupport.firePropertyChange("cpfCnpj", oldCpfCnpj, cpfCnpj);
    }

    public String getInscrEstadual() {
        return inscrEstadual;
    }

    public void setInscrEstadual(String inscrEstadual) {
        String oldInscrEstadual = this.inscrEstadual;
        this.inscrEstadual = inscrEstadual;
        changeSupport.firePropertyChange("inscrEstadual", oldInscrEstadual, inscrEstadual);
    }

    public String getInscrMunicipal() {
        return inscrMunicipal;
    }

    public void setInscrMunicipal(String inscrMunicipal) {
        String oldInscrMunicipal = this.inscrMunicipal;
        this.inscrMunicipal = inscrMunicipal;
        changeSupport.firePropertyChange("inscrMunicipal", oldInscrMunicipal, inscrMunicipal);
    }

    public Character getTipo() {
        return tipo;
    }

    public void setTipo(Character tipo) {
        Character oldTipo = this.tipo;
        this.tipo = tipo;
        changeSupport.firePropertyChange("tipo", oldTipo, tipo);
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (idfor != null ? idfor.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Fornecedor)) {
            return false;
        }
        Fornecedor other = (Fornecedor) object;
        if ((this.idfor == null && other.idfor != null) || (this.idfor != null && !this.idfor.equals(other.idfor))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "ni.semed.ieducaralimentacao.Fornecedor[ idfor=" + idfor + " ]";
    }

    public void addPropertyChangeListener(PropertyChangeListener listener) {
        changeSupport.addPropertyChangeListener(listener);
    }

    public void removePropertyChangeListener(PropertyChangeListener listener) {
        changeSupport.removePropertyChangeListener(listener);
    }

}
