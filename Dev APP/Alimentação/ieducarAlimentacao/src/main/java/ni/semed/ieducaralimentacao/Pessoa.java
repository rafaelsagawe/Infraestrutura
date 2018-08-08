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
@Table(name = "pessoa", catalog = "ieducar", schema = "alimentos")
@NamedQueries({
    @NamedQuery(name = "Pessoa.findAll", query = "SELECT p FROM Pessoa p")
    , @NamedQuery(name = "Pessoa.findByIdpes", query = "SELECT p FROM Pessoa p WHERE p.idpes = :idpes")
    , @NamedQuery(name = "Pessoa.findByTipo", query = "SELECT p FROM Pessoa p WHERE p.tipo = :tipo")})
public class Pessoa implements Serializable {

    @Transient
    private PropertyChangeSupport changeSupport = new PropertyChangeSupport(this);

    private static final long serialVersionUID = 1L;
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Basic(optional = false)
    @Column(name = "idpes")
    private Integer idpes;
    @Basic(optional = false)
    @Column(name = "tipo")
    private String tipo;

    public Pessoa() {
    }

    public Pessoa(Integer idpes) {
        this.idpes = idpes;
    }

    public Pessoa(Integer idpes, String tipo) {
        this.idpes = idpes;
        this.tipo = tipo;
    }

    public Integer getIdpes() {
        return idpes;
    }

    public void setIdpes(Integer idpes) {
        Integer oldIdpes = this.idpes;
        this.idpes = idpes;
        changeSupport.firePropertyChange("idpes", oldIdpes, idpes);
    }

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        String oldTipo = this.tipo;
        this.tipo = tipo;
        changeSupport.firePropertyChange("tipo", oldTipo, tipo);
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (idpes != null ? idpes.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Pessoa)) {
            return false;
        }
        Pessoa other = (Pessoa) object;
        if ((this.idpes == null && other.idpes != null) || (this.idpes != null && !this.idpes.equals(other.idpes))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "ni.semed.ieducaralimentacao.Pessoa[ idpes=" + idpes + " ]";
    }

    public void addPropertyChangeListener(PropertyChangeListener listener) {
        changeSupport.addPropertyChangeListener(listener);
    }

    public void removePropertyChangeListener(PropertyChangeListener listener) {
        changeSupport.removePropertyChangeListener(listener);
    }

}
